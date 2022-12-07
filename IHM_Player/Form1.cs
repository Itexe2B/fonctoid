using Data;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace IHM_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayData_Click(object sender, EventArgs e)
        {

            Data.Data.header = new List<string>()
            {
                "Id", "Name", "Last Name", "Paris"
            };

            Data.Data.csv = new List<List<string>>()
            {
                new List<string>() { "1", "John", "Doe", "Paris" },
                new List<string>() { "2", "Jane", "Doe", "Paris" },
                new List<string>() { "3", "John", "Doe", "Paris" },
                new List<string>() { "4", "Jane", "Doe", "Paris" },
                new List<string>() { "5", "John", "Doe", "Paris" },
                new List<string>() { "6", "Jane", "Doe", "Paris" },
                new List<string>() { "7", "John", "Doe", "Paris" },
                new List<string>() { "8", "Jane", "Doe", "Paris" },
                new List<string>() { "9", "John", "Doe", "Paris" },
                new List<string>() { "10", "Jane", "Doe", "Paris" },
                new List<string>() { "11", "John", "Doe", "Paris" },
                new List<string>() { "12", "Jane", "Doe", "Paris" },
                new List<string>() { "13", "John", "Doe", "Paris" },
                new List<string>() { "14", "Jane", "Doe", "Paris" },
                new List<string>() { "15", "John", "Doe", "Paris" },
                new List<string>() { "16", "Jane", "Doe", "Paris" },
                new List<string>() { "17", "John", "Doe", "Paris" },
                new List<string>() { "18", "Jane", "Doe", "Paris" },
                new List<string>() { "19", "John", "Doe", "Paris" },
                new List<string>() { "20", "Jane", "Doe", "Paris" },
                new List<string>() { "21", "John", "Doe", "Paris" },
                new List<string>() { "22", "Jane", "Doe", "Paris" },
                new List<string>() { "23", "John", "Doe", "Paris" },
                new List<string>() { "24", "Jane", "Doe", "Paris" }
            };
            
            Data.Data.header.ForEach(@v => dataGridView.Columns.Add(@v, @v));
            for (int i = 0; i < Data.Data.csv.Count; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < Data.Data.csv[i].Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Data.Data.csv[i][j];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}