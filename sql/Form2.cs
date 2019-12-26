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
        private String connectionString =
                "Data Source=DESKTOP-J8PKM7S\\MYDATABASE;" +
                "Initial Catalog=csharp;" +
                "Integrated Security=SSPI;";
        SqlConnection cnn = new SqlConnection();

        public Form2()
        {
            InitializeComponent();
            
            cnn = new SqlConnection(connectionString);
        }
        private string sqlSelect( string query)
        {
            string outputString = "";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    outputString = outputString + reader[i] + "\n";
                                }

                            }
                        }
                    } // reader closed

                }
            }
            catch
            {
                MessageBox.Show("Invalid SELECT or connection lost!");

            }
            return outputString;
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
                cnn.Open();
                connectionInfo.Text = "You Are Connected";
                connectionInfo.ForeColor = Color.FromArgb(92, 230, 71);
            }
            catch(SqlException)
            {
                MessageBox.Show("Something gone wrong!");
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            displayBox.Text = sqlSelect(textQuery.Text);

        }
    }
}
