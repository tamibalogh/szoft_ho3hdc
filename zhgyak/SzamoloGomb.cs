using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    internal class SzamoloGomb : Button
    {
        int kiindulas = 1;
        public SzamoloGomb()
        {
            this.Height = 20;
            this.Width = 20;

            Click += SzamoloGomb_Click;

            this.Text = kiindulas.ToString();

            
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            int ertek = int.Parse(this.Text);

            if (ertek == 5)
            {
                this.Text = kiindulas.ToString();
            } else
            {
                this.Text = (ertek + 1).ToString();
            }
            
        }

        public int szam { get; set; }
    }
}
