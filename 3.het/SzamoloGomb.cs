using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.het
{
    internal class SzamoloGomb : VillogoGomb
    {
        int szam = 1;

        public SzamoloGomb()
        {
            MouseClick += SzamoloGomb_MouseClick;
            Text = szam.ToString();
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            Text = (szam++).ToString();
        }
    }
}
