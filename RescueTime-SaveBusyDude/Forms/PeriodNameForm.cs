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
    public partial class PeriodNameForm : Form
    {
        public ConfigModel.JsonConfig _config;
        public int formType = 0;

        public PeriodNameForm(ConfigModel.JsonConfig config,int formType)
        {
            this._config = config;
            this.formType = formType;
            InitializeComponent();
            cbPeriodName.DataSource = _config.Period;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
