using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RescueTime_SaveBusyDude.Forms
{
    public partial class SpecificNameForm : Form
    {
        public SpecificNameForm()
        {
            InitializeComponent();
        }

        public string GetName()
        {
            return textBox1.Text;
        }
    }
}
