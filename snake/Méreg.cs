using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Méreg : PictureBox
    {
        public static int Méret = 20;
        public Méreg()
        {
            Width = Méreg.Méret;
            Height = Méreg.Méret;
            BackColor = Color.DarkGreen;
        }
    }
}
