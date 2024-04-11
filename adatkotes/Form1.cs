using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();

        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fce = new Form2();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Write records to the CSV file
                csv.WriteRecords(countryList);
            };
        }
    }
}