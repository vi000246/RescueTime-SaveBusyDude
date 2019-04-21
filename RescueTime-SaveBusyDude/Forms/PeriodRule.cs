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
    public partial class PeriodRule : Form
    {
        public PeriodRule()
        {
            InitializeComponent();
        }

        private void btnPeriodSave_Click(object sender, EventArgs e)
        {
            //validation
            var period = ConfigUtil.GetPeriodRuleByPeriodName(tbPeriodName.Text);
            if (period != null)
            {
                MessageBox.Show("PeriodName is exist! Please select another name.");
            }
            else if (string.IsNullOrEmpty(tbPeriodName.Text))
            {
                MessageBox.Show("PeriodName cannot be empty!");
            }
            else
            {
                ConfigUtil.InsertUpdatePeriodRule(new ConfigModel.PeriodRule()
                {
                    PeriodName = tbPeriodName.Text,
                    Hour_begin = Convert.ToInt32(tbHourBebin.Value),
                    Hour_end = Convert.ToInt32(tbHourEnd.Value)
                });
            }

            this.Close();
        }
    }
}
