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
    public partial class EnableDaysForm : Form
    {
        public ConfigModel.JsonConfig _config;

        public EnableDaysForm(ConfigModel.JsonConfig config)
        {
            InitializeComponent();
            this._config = config;
            cbEnableDays.DataSource = Enum.GetValues(typeof(EnumModule.WeekDays)); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
