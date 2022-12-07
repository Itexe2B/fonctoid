using CsvHelper;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IHM_Designer
{
    public partial class Form1 : Form
    {
        public static String? UrlFile = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            //openFileDialog1.DefaultExt = ".csv";
            //openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            UrlFile = openFileDialog1.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UrlFile == null)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                //openFileDialog1.DefaultExt = ".csv";
                //openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
                UrlFile = openFileDialog1.FileName;
            }

            using (var reader = new StreamReader(UrlFile!))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                var test = csv.Read();
                csv.ReadHeader();
                foreach (string arrItem in csv.HeaderRecord)
                {
                    Data.Data.header.Add(arrItem);
                }
                //Stock header in Data.data.header

                while (csv.Read())
                {
                    for (int i = 0; i < Data.Data.header.Count; i++)
                    {
                        Data.Data.csv[i].Add(csv.GetField<string>(Data.Data.header[i]));
                    }
                }
            }
        }
    }
}