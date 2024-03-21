namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        int lépésszám = 0;

        int hossz = 8;

        List<KígyóElem> kígyó = new List<KígyóElem>();

        Random rnd = new Random();
        int alma_x = 0;
        int alma_y = 0;

        int méreg_x = 0;
        int méreg_y = 0;

        int méret = 20;
        Alma a = new Alma();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            if (alma_x == 0 && alma_y == 0)
            {
                
                alma_x = (rnd.Next(1, 10) * méret);
                alma_y = (rnd.Next(1, 10) * méret);
                a.Top = alma_x;
                a.Left = alma_y;
                Controls.Add(a);
            }

            if (méreg_x == 0 && méreg_y == 0)
            {
                Méreg m = new Méreg();
                méreg_x = (rnd.Next(1, 10) * méret);
                méreg_y = (rnd.Next(1, 10) * méret);
                m.Top = méreg_x;
                m.Left = méreg_y;
                Controls.Add(m);
            }

            //fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;
            KígyóElem ke = new KígyóElem();
            kígyó.Add(ke); //amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is
            Controls.Add(ke); //és az ûrlap vezérlõinek a listájába is


            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            //KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            //Controls.Add(ke);

            //farokvágás
            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

            if (fej_x == alma_x && fej_y == alma_y)
            {
                alma_x = rnd.Next(1, 400);
                alma_y = rnd.Next(1, 400);
                a.Top = alma_x;
                a.Left = alma_y;
                Controls.Add(a);
            }

            if (fej_x == méreg_x && fej_y == méreg_y)
            {
                timer1.Enabled = false;
                return;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }

        
    }
}