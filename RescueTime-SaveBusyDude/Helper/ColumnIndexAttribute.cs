using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueTime_SaveBusyDude.Helper
{

    public class ColumnIndexAttribute : Attribute
    {
        private int ColumnIndex { get; set; }

        public ColumnIndexAttribute(int index)
        {
            this.ColumnIndex = index;
        }
        public int Index
        {
            get { return ColumnIndex; }
        }

        public override string ToString()
        {
            return this.ColumnIndex.ToString();
        }
    }
}
