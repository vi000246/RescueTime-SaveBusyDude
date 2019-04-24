﻿using System;
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
        public bool IsConfigModify = false;

        public ConfigForm()
        {
            InitializeComponent();
            BindingDataToControl();
            ChangeFormSize(this.tcConfigForm.SelectedTab.Name);
            this.tcConfigForm.Selecting += new TabControlCancelEventHandler(tcConfigForm_Selecting);
        }

        #region FormControl
        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsConfigModify)
            {
                DialogResult result =
                    MessageBox.Show(
                        "Restart application to refresh config?",
                        "Yes",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }
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
            this.IsConfigModify = true;
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
            //p.s. 這裡的排序是Column Index的排序
            var itemStates = _config.Alert.Select(x=>new
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
            var bindingSource1 = new System.Windows.Forms.BindingSource { DataSource = itemStates };
            this.gvAlertRule.DataSource = bindingSource1;
            //            this.gvAlertRule.DataSource = _config.Alert;
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
        private void gvAlertRule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                var alertName = dgv.CurrentRow.Cells["alertName"].Value;
                var popupForm = new AlertRuleForm(_config,EnumModule.formType.Add);
                popupForm.FormClosed += new FormClosedEventHandler(AlertRuleForm_Closed);
                popupForm.Show();
            }

        }
        private void AlertRuleForm_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshConfig();
            gvAlertRule.Update();
            gvAlertRule.Refresh();
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
                this.IsConfigModify = true;
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
            List<string> modifyAlertRule = new List<string>();
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
                    _config.Alert.Where(x =>
                        x.PeriodName.Contains(periodName) || x.EnablePeriodName.Contains(periodName))
                        .ToList()
                        .ForEach(x =>
                        {
                            x.EnablePeriodName = x.EnablePeriodName.Where(w => w != periodName).ToArray();
                            x.PeriodName = x.PeriodName.Where(w => w != periodName).ToArray();
                            ConfigUtil.InsertUpdateAlertRule(x);
                            modifyAlertRule.Add(x.alertName);
                        });

                    ConfigUtil.DeletePeriodRuleByName(periodName);
                }
            }

            RefreshConfig();
            BindPeriodGridView();
            gvPeriodSetting.Update();
            gvPeriodSetting.Refresh();
            if (modifyAlertRule.Count > 0)
            {
                MessageBox.Show("Below alert rule has been modified：\n"+string.Join(",",modifyAlertRule));
                initAlertRuleDataView();
                gvAlertRule.Update();
                gvAlertRule.Refresh();
            }
        }






        #endregion

        #region  ===========  Activity Search  ==========
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keywords = tbSearchField.Text.Replace("\r\n", "").Split(',');
            if (keywords.Length == 0)
            {
                MessageBox.Show("Please input keywords, Separated by commas");
                return;
            }

            var res = RescueTimeAPI.GetAllActivityData(DateTime.Now.AddMonths(-3),DateTime.Now);
            var result = res.Where(x => 
                keywords.Any(s => s.Equals(x.Activity, StringComparison.OrdinalIgnoreCase)) ||
                keywords.Any(s => s.Equals(x.Category, StringComparison.OrdinalIgnoreCase))
            );
            var strResult = result.GroupBy(x => x.Category).Select(g => new
            {
                Activity = g.First().Activity,
                Category = g.Key,
                TimeSpent = g.Sum(x=>x.TimeSpent)
            })
            .Select(s => 
                $"Activity: {s.Activity}  Category: {s.Category}  TimeSpent: {s.TimeSpent}"
            ).ToList();
            tbSearchResult.DataSource = strResult;
        }


        #endregion


    }
}
