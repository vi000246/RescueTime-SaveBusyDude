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
    public partial class ConfigForm : Form
    {
        public ConfigModel.JsonConfig _config = ConfigUtil.GetJsonConfigData();

        public ConfigForm()
        {
            InitializeComponent();
            BindingDataToControl();
            this.tcConfigForm.Selecting += new TabControlCancelEventHandler(tcConfigForm_Selecting);
            ChangeFormSize(this.tcConfigForm.SelectedTab.Name);
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

        public void BindingDataToControl()
        {
            initAlertRuleDataView();
            initPeriodRuleDataView();
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
            this.gvAlertRule.AutoGenerateColumns = false;
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

        public void initPeriodRuleDataView()
        {
            this.gvPeriodSetting.DataSource = _config.Period;
        }

        public void RefreshAlertRuleDataView()
        {

        }

        public void RefreshPeriodRuleDataView()
        {

        }
    }
}
