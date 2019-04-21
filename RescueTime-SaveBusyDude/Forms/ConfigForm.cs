using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RescueTime_SaveBusyDude.Helper;
using RescueTime_SaveBusyDude.Model;

namespace RescueTime_SaveBusyDude.Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigModel.JsonConfig _config = ConfigUtil.GetJsonConfigData();

        public ConfigForm()
        {
            InitializeComponent();
            BindingDataToControl();
            ChangeFormSize(this.tcConfigForm.SelectedTab.Name);
            this.tcConfigForm.Selecting += new TabControlCancelEventHandler(tcConfigForm_Selecting);
            this.gvAlertRule.AutoGenerateColumns = false;
        }

        #region FormControl

        void tcConfigForm_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            ChangeFormSize(current.Name);
        }

        void ChangeFormSize(string pageName)
        {
            if (pageName == "AlertRule")
            {
                this.Width = 1161;
                this.tcConfigForm.Width = 1129;
            }
            else
            {
                this.Width = 570;
                this.tcConfigForm.Width = 542;
            }
        }

        void RefreshConfig()
        {
            this._config = ConfigUtil.GetJsonConfigData();
        }

        public void BindingDataToControl()
        {
            initAlertRuleDataView();
            BindPeriodGridView();
            initDropDown();
            this.tbApiKey.Text = _config.Apikey;
        }

        public void initDropDown()
        {
            cbBlockingMode.DataSource = Enum.GetValues(typeof(EnumModule.BlockingMode));
            cbBlockingMode.SelectedItem = _config.Focus.BlockingMode;
        }

        public void initAlertRuleDataView()
        {
            this.gvAlertRule.DataSource = _config.Alert.Select(x=>new
            {
                Hour = x.Hour,
                Minute = x.Minute,
                AlertName = x.alertName,
                AlertType = x.AlertType,
                SpecificName = string.Join(",",x.SpecificName),
                PeriodName = string.Join(",",x.PeriodName),
                CustomMessage = x.CustomMessage,
                BlockWhenTrigger = x.BlockWhenTrigger,
                EnableDays = string.Join(",",x.EnableDays),
                EnablePeriodName = string.Join(",",x.EnablePeriodName)
            }).ToList();
        }

        public void BindPeriodGridView()
        {
            this.gvPeriodSetting.DataSource = _config.Period;
        }
        #endregion

        #region  ============  basic  ============

        #endregion

        #region ============  AlertRule  ============
        private void gvAlertRule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        #region ============  Period  ============
        int ValueBeforeEdit;
        private void gvPeriodSetting_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bool isInt = int.TryParse(gvPeriodSetting.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() ?? "", out ValueBeforeEdit);
        }

        private void gvPeriodSetting_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int value = -1;
            string periodName = gvPeriodSetting.Rows[e.RowIndex].Cells[AttributeHelper.GetColumnIndex<ConfigModel.PeriodRule>("PeriodName")].Value.ToString() ?? "";
            bool isInt = int.TryParse(gvPeriodSetting.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()??"",out value);
            bool isValid = true;
            gvPeriodSetting.Rows[e.RowIndex].ErrorText = "";

            //update json
            var period = _config.Period.FirstOrDefault(x => x.PeriodName == periodName);
            if (period != null)
            {
                if (e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.PeriodRule>("Hour_begin"))
                {
                    period.Hour_begin = value;
                }
                else if (e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.PeriodRule>("Hour_end"))
                {
                    period.Hour_end = value;
                }

                ConfigUtil.InsertUpdatePeriodRule(period);
            }
        }
        private void gvPeriodSetting_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            int value = -1;
            bool isInt = int.TryParse(e.FormattedValue.ToString(), out value);
            if (gvPeriodSetting.Rows[e.RowIndex].IsNewRow) { return; }

            if (e.ColumnIndex != AttributeHelper.GetColumnIndex<ConfigModel.PeriodRule>("PeriodName"))
            {
                if (!isInt)
                {
                    gvPeriodSetting.Rows[e.RowIndex].ErrorText = "Value should be int";
                    e.Cancel = true;
                }
            }
        }


        private void btnPeriod_Add_Click(object sender, EventArgs e)
        {
            var popupForm = new PeriodRule();
            popupForm.FormClosed += new FormClosedEventHandler(PeriodForm_Closed);
            popupForm.Show();
        }

        private void PeriodForm_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshConfig();
            BindPeriodGridView();
            gvPeriodSetting.Update();
            gvPeriodSetting.Refresh();
        }
        private void btnPeriodDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dr = gvPeriodSetting.SelectedRows;

            DialogResult result =
                MessageBox.Show(
                    "Confirm delete this record?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dr.Count; i++)
                {
                    string periodName = dr[i]
                        .Cells[AttributeHelper.GetColumnIndex<ConfigModel.PeriodRule>("PeriodName")].Value.ToString();
                    ConfigUtil.DeletePeriodRuleByName(periodName);
                }
            }

            RefreshConfig();
            BindPeriodGridView();
            gvPeriodSetting.Update();
            gvPeriodSetting.Refresh();
        }
        #endregion


    }
}
