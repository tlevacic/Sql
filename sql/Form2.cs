using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Close form2
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();    
        }
        //Connection access
        private void connectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                SqlConnection cnn = new SqlConnection();

                connectionString =
                "Data Source=DESKTOP-J8PKM7S\\MYDATABASE;" +
                "Initial Catalog=csharp;" +
                "Integrated Security=SSPI;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                connectionInfo.Text = "You Are Connected";
                connectionInfo.ForeColor = Color.FromArgb(92, 230, 71);
                
            }
            catch(SqlException)
            {
                MessageBox.Show("Something gone wrong!");
            }
        }
    }
}
