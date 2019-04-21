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
            DataGridViewComboBoxColumn cbAlertType =
                gvAlertRule.Columns[AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("AlertType")] as DataGridViewComboBoxColumn;
            cbAlertType.DataSource = Enum.GetValues(typeof(EnumModule.AlertType));
        }


        public void initAlertRuleDataView()
        {
            //p.s. 這裡的排序是Column Index的排序
            this.gvAlertRule.DataSource = _config.Alert.Select(x=>new
            {
                AlertName = x.alertName,
                AlertType = x.AlertType,
                Hour = x.Hour,
                Minute = x.Minute,
                SpecificName = string.Join(",",x.SpecificName),
                PeriodName = string.Join(",",x.PeriodName),
                EnableDays = string.Join(",", x.EnableDays),
                EnablePeriodName = string.Join(",", x.EnablePeriodName),
                BlockWhenTrigger = x.BlockWhenTrigger,
                CustomMessage = x.CustomMessage
            }).ToList();
        }

        public void BindPeriodGridView()
        {
            this.gvPeriodSetting.DataSource = _config.Period;
        }
        #endregion

        #region  ============  basic  ============
        private void btnSaveBasic_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region ============  AlertRule  ============

        private void gvAlertRule_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvAlertRule_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("Hour") ||
                e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("AlertType") ||
                e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("Minute") ||
                e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("SpecificName") ||
                e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("CustomMessage")||
                e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("BlockWhenTrigger")
            )
            {
                var columnName = AttributeHelper.GetColumnNameByIndex<ConfigModel.AlertRule>(e.ColumnIndex);
                DataGridViewCell cell = gvAlertRule[columnName, e.RowIndex];
                gvAlertRule.CurrentCell = cell;
                gvAlertRule.CurrentCell.ReadOnly = false;
                gvAlertRule.BeginEdit(true);
            }
            else if (e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("PeriodName"))
            {
                new PeriodNameForm(_config,1).Show();
            }
            else if (e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("EnablePeriodName"))
            {
                new PeriodNameForm(_config, 2).Show();
            }
            else if (e.ColumnIndex == AttributeHelper.GetColumnIndex<ConfigModel.AlertRule>("EnableDays"))
            {
                new EnableDaysForm(_config).Show();
            }
        }

        private void gvPeriodSetting_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
//            gvAlertRule.EndEdit();
        }

        private void gvAlertRule_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void gvAlertRule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvAlertRule_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void gvAlertRule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
