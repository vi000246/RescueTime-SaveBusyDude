using System;
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
        public ConfigModel.AlertRule alertRule;

        public AlertRuleForm(ConfigModel.JsonConfig config,EnumModule.formType formType,string alertName)
        {
            this._config = config;
            this.formType = formType;
            this.alertRule = config.Alert.FirstOrDefault(x => x.alertName == alertName);
            InitializeComponent();
            cbPeriodName.DataSource = _config.Period;
            cbPeriodName.DisplayMember = "PeriodName";
            cbPeriodName.ValueMember = "PeriodName";
            cbEnablePeriodName.DataSource = _config.Period;
            cbEnablePeriodName.DisplayMember = "PeriodName";
            cbEnablePeriodName.ValueMember = "PeriodName";
            cbEnableDays.DataSource = Enum.GetValues(typeof(EnumModule.WeekDays));
            initControl();
            if (formType == EnumModule.formType.Edit)
            {
                initData();
            }
        }

        private void initControl()
        {

        }

        private void initData()
        {
            cbAlertType.SelectedItem = alertRule.AlertType;
            ddHour.Value = alertRule.Hour;
            ddMinute.Value = alertRule.Minute;
            cbBlockWhenTrigger.Checked = alertRule.BlockWhenTrigger;
            tbCusomMessage.Text = alertRule.CustomMessage;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formType == EnumModule.formType.Add)
            {

            }
            else
            {

            }
        }
    }
}
