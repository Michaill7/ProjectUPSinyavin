using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static ProjectUP.SqlClass;

namespace ProjectUP
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        DataTable table;
        SqlCommandBuilder builder;

        public Form1()
        {
            connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ProjectUPDB; Integrated Security = True");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = SqlQuery("SELECT * FROM NAMES", connection);
            DataWindow.DataSource = table;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            builder = new SqlCommandBuilder();
            var answer = MessageBox.Show("Are you sure?", "Notification",MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {

            }
        }
    }
}
