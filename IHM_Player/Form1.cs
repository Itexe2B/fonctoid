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