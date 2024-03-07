using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    internal class SzinezodoGomb : Button
    {
        public SzinezodoGomb()
        {
            this.Height = 20;
            this.Width = 20;

            Click += SzinezodoGomb_Click;
        }

        private void SzinezodoGomb_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }
}
