using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajosKviz
{
    internal class VálaszGomb : TextBox
    {
        public VálaszGomb()
        {
            ReadOnly = true;
            BackColor = Color.Gray;
            BorderStyle = BorderStyle.None;
            Multiline = true;
        }
    }
}
