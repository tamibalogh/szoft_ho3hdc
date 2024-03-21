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

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int l�p�ssz�m = 0;

        int hossz = 8;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        Random rnd = new Random();
        int alma_x = 0;
        int alma_y = 0;

        int m�reg_x = 0;
        int m�reg_y = 0;

        int m�ret = 20;
        Alma a = new Alma();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            if (alma_x == 0 && alma_y == 0)
            {
                
                alma_x = (rnd.Next(1, 10) * m�ret);
                alma_y = (rnd.Next(1, 10) * m�ret);
                a.Top = alma_x;
                a.Left = alma_y;
                Controls.Add(a);
            }

            if (m�reg_x == 0 && m�reg_y == 0)
            {
                M�reg m = new M�reg();
                m�reg_x = (rnd.Next(1, 10) * m�ret);
                m�reg_y = (rnd.Next(1, 10) * m�ret);
                m.Top = m�reg_x;
                m.Left = m�reg_y;
                Controls.Add(m);
            }

            //fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;
            K�gy�Elem ke = new K�gy�Elem();
            k�gy�.Add(ke); //amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is
            Controls.Add(ke); //�s az �rlap vez�rl�inek a list�j�ba is


            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            //K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            //Controls.Add(ke);

            //farokv�g�s
            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

            if (fej_x == alma_x && fej_y == alma_y)
            {
                alma_x = rnd.Next(1, 400);
                alma_y = rnd.Next(1, 400);
                a.Top = alma_x;
                a.Left = alma_y;
                Controls.Add(a);
            }

            if (fej_x == m�reg_x && fej_y == m�reg_y)
            {
                timer1.Enabled = false;
                return;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }

        
    }
}