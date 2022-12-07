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
            openFileDialog1.DefaultExt = ".csv";
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            UrlFile = openFileDialog1.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UrlFile == null)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                openFileDialog1.DefaultExt = ".csv";
                openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
                UrlFile = openFileDialog1.FileName;
            }

            using (var reader = new StreamReader(UrlFile!))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                csv.Read();
                csv.ReadHeader();

                //Stock header in Data.data.header

                var has_header = true;
                var csv_headers = new List<string>();
                var header_index = 0;
                while (csv.Read())
                {
                    has_header = csv.TryGetField<string>(header_index, out string? header_name);

                    if (has_header)
                    {
                        header_index += 1;
                        csv_headers.Add(header_name);

                    }

                    for (var i = 0; i < csv_headers.Count; i++)
                    {
                        Data.Data.csv[i] = csv.GetField<String>(csv_headers[i]);
                    }
                    //

                    //}

                    //Se servir de GetField pour stocker dans data.csv
                    //Tu as les noms des fields grace a header.
                }
            }
        }
    }
}