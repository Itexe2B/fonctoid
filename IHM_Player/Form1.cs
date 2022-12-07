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
            dataGridView.DataSource = new Dictionary<string, List<String>>()
            {
                { "Id2", Data.Data.header}
            };

            dataGridView.DataSource = Data.Data.header.Select(@v => new { @v }).ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}