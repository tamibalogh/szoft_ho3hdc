namespace zhgyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int size = 20;
            Random rnd = new Random();

            //Button gombi = new Button();
            //gombi.Height = size;
            //gombi.Width = size;
            //gombi.Left = (ClientRectangle.Width / 2) - size;
            //gombi.Top = (ClientRectangle.Height / 2) - size;
            //Controls.Add(gombi);

            //for (int i = 0; i < 100; i++)
            //{
            //Button b = new Button();

            //b.Height = rnd.Next(1, 100);
            //b.Width = rnd.Next(1, 100);
            //b.Top = rnd.Next(1, (ClientRectangle.Height-size));
            //b.Left = rnd.Next(1, (ClientRectangle.Width-size));
            //b.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            //Controls.Add(b);
            //}

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j >= i)
                    {
                        Button gombi = new Button();
                        gombi.Height = size;
                        gombi.Width = size;
                        gombi.Left = ((ClientRectangle.Width)/2 + (size * i))-(size*i)/2;
                        gombi.Top = size * j;
                        Controls.Add(gombi);
                    }
                    
                    
                }
            }
        }
    }
}
