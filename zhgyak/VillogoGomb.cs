﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }
}
