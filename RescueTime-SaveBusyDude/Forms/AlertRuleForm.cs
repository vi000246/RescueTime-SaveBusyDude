﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RescueTime_SaveBusyDude.Model;

namespace RescueTime_SaveBusyDude.Forms
{
    public partial class AlertRuleForm : Form
    {
        public ConfigModel.JsonConfig _config;
        public EnumModule.formType  formType = 0;
        public ConfigModel.AlertRule alertRule = new ConfigModel.AlertRule();

        public AlertRuleForm(ConfigModel.JsonConfig config,EnumModule.formType formType,string alertName)
        {
            this._config = config;
            this.formType = formType;
            InitializeComponent();
            cbPeriodName.DataSource = _config.Period;
            cbPeriodName.DisplayMember = "PeriodName";
            cbPeriodName.ValueMember = "PeriodName";
            cbEnablePeriodName.DataSource = _config.Period;
            cbEnablePeriodName.DisplayMember = "PeriodName";
            cbEnablePeriodName.ValueMember = "PeriodName";
            cbEnableDays.DataSource = Enum.GetValues(typeof(EnumModule.WeekDays));
            cbAlertType.DataSource = Enum.GetValues(typeof(EnumModule.AlertType));
            if (formType == EnumModule.formType.Edit)
            {
                this.alertRule = config.Alert.FirstOrDefault(x => x.alertName == alertName);
                tbAlertName.Visible = false;
                initData();
            }
            else
            {
                //auto choose default weekday
                for (int count = 0; count < cbEnableDays.Items.Count; count++)
                {
                    if ((EnumModule.WeekDays)cbEnableDays.Items[count] != EnumModule.WeekDays.Saturday &&
                        (EnumModule.WeekDays)cbEnableDays.Items[count] != EnumModule.WeekDays.Sunday)
                    {
                        cbEnableDays.SetItemChecked(count, true);
                    }
                }
            }
        }

        private void initData()
        {
            cbAlertType.SelectedItem = alertRule.AlertType;
            ddHour.Value = alertRule.Hour;
            ddMinute.Value = alertRule.Minute;
            cbBlockWhenTrigger.Checked = alertRule.BlockWhenTrigger;
            tbCusomMessage.Text = alertRule.CustomMessage;
            lbAlertName.Text = alertRule.alertName;
            foreach (var name in alertRule.SpecificName)
            {
                lbSpecificName.Items.Add(name);
            }
            for (int count = 0; count < cbPeriodName.Items.Count; count++)
            {
                if (alertRule.PeriodName.Contains(((ConfigModel.PeriodRule)cbPeriodName.Items[count]).PeriodName.ToString()))
                {
                    cbPeriodName.SetItemChecked(count, true);
                }
            }
            for (int count = 0; count < cbEnablePeriodName.Items.Count; count++)
            {
                if (alertRule.EnablePeriodName.Contains(((ConfigModel.PeriodRule)cbEnablePeriodName.Items[count]).PeriodName.ToString()))
                {
                    cbEnablePeriodName.SetItemChecked(count, true);
                }
            }
            for (int count = 0; count < cbEnableDays.Items.Count; count++)
            {
                if (alertRule.EnableDays.Contains((EnumModule.WeekDays)cbEnableDays.Items[count]))
                {
                    cbEnableDays.SetItemChecked(count, true);
                }
            }

        }

        private bool validate()
        {
            string errorMsg = "";
            if (this.formType == EnumModule.formType.Add && string.IsNullOrEmpty(tbAlertName.Text))
            {
                errorMsg += "AlertName cannot be empty\n";
            }
            
            if (cbAlertType.SelectedIndex == -1)
            {
                errorMsg += "Please select AlertType\n";
            }

            if (ddHour.Value == 0 && ddMinute.Value == 0)
            {
                errorMsg += "Please set Hour/Minute value\n";
            }

            if (cbPeriodName.CheckedItems.Count == 0)
            {
                errorMsg += "Please choose PeriodName\n";
            }

            if (cbEnablePeriodName.CheckedItems.Count == 0)
            {
                errorMsg += "Please choose EnablePeriodName\n";
            }

            if (cbEnableDays.CheckedItems.Count == 0)
            {
                errorMsg += "Please choose EnableDays\n";
            }

            if(string.IsNullOrEmpty(errorMsg))
                return true;
            else
            {
                MessageBox.Show(errorMsg);
                return false;
            }
        }

        private void BindDataFromControl()
        {
            this.alertRule.AlertType = (EnumModule.AlertType) cbAlertType.SelectedItem;
            this.alertRule.Hour = int.Parse(ddHour.Value.ToString());
            this.alertRule.Minute = int.Parse(ddMinute.Value.ToString());
            this.alertRule.BlockWhenTrigger = cbBlockWhenTrigger.Checked;
            this.alertRule.CustomMessage = tbCusomMessage.Text;
            this.alertRule.SpecificName = lbSpecificName.Items.Cast<string>().ToArray();
            this.alertRule.PeriodName = cbPeriodName.CheckedItems.Cast<ConfigModel.PeriodRule>().Select(x => x.PeriodName).ToArray();
            this.alertRule.EnablePeriodName = cbEnablePeriodName.CheckedItems.Cast<ConfigModel.PeriodRule>().Select(x=>x.PeriodName).ToArray();
            this.alertRule.EnableDays = cbEnableDays.CheckedItems.Cast<EnumModule.WeekDays>().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formType == EnumModule.formType.Add)
            {
                AddDataProcess();
            }
            else
            {
                EditDataProcess();
            }
        }

        private void AddDataProcess()
        {
            if (validate())
            {
                BindDataFromControl();
                ConfigUtil.InsertUpdateAlertRule(this.alertRule);
                MessageBox.Show("Add Success!");
            }
        }

        private void EditDataProcess()
        {
            if (validate())
            {
                BindDataFromControl();
                ConfigUtil.InsertUpdateAlertRule(this.alertRule);
                MessageBox.Show("Edit Sucess!");
            }
        }
        private void cbPeriodName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbPeriodName.Items.Count; i++)
            {
                if (cbPeriodName.GetItemRectangle(i).Contains(cbPeriodName.PointToClient(MousePosition)))
                {
                    switch (cbPeriodName.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            cbPeriodName.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            cbPeriodName.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }

                }

            }
        }

        private void cbEnablePeriodName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbEnablePeriodName.Items.Count; i++)
            {
                if (cbEnablePeriodName.GetItemRectangle(i).Contains(cbEnablePeriodName.PointToClient(MousePosition)))
                {
                    switch (cbEnablePeriodName.GetItemCheckState(i))
                    {
                        case CheckState.Checked:
                            cbEnablePeriodName.SetItemCheckState(i, CheckState.Unchecked);
                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            cbEnablePeriodName.SetItemCheckState(i, CheckState.Checked);
                            break;
                    }

                }

            }
        }

        private void lbSpecificName_DoubleClick(object sender, EventArgs e)
        {
            SpecificNameForm snForm = new SpecificNameForm();

            if (snForm.ShowDialog(this) == DialogResult.OK)
            {
                var SName = snForm.GetName();
                if (!string.IsNullOrEmpty(SName) && ListBox.NoMatches == lbSpecificName.FindStringExact(SName))
                {
                    lbSpecificName.Items.Add(SName);
                }
            }
            snForm.Dispose();
        }

        private void lbSpecificName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbSpecificName);
                selectedItems = lbSpecificName.SelectedItems;

                if (lbSpecificName.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        lbSpecificName.Items.Remove(selectedItems[i]);
                }
                else
                    MessageBox.Show("Select at least one SpecificName to delete.");
            }
        }
    }
}
