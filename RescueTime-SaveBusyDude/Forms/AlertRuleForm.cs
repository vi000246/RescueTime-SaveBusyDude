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

        public AlertRuleForm(ConfigModel.JsonConfig config,EnumModule.formType formType)
        {
            this._config = config;
            this.formType = formType;
            InitializeComponent();
            cbPeriodName.DataSource = _config.Period;
            cbEnableDays.DataSource = Enum.GetValues(typeof(EnumModule.WeekDays));
            if (formType == EnumModule.formType.Add)
            {
                initData();
            }
        }

        private void initData()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
