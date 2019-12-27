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
        private bool sqlInsert (string query)
        {
            try
            {
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                cmd = new SqlCommand(query, cnn);
                adapter.InsertCommand = new SqlCommand(query, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                return true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Insert not completed. Please try again.");
                return false;
            }
        }
        private bool sqlUpdate(string query)
        {
            try
            {
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                cmd = new SqlCommand(query, cnn);
                adapter.UpdateCommand = new SqlCommand(query, cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Update not completed. Please try again.");
                return false;
            }
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
                                    outputString = outputString + reader[i] + "\t";
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
            switch (textQuery.Text.Split(' ')[0])
            {
                case "Select":
                    displayBox.Text = sqlSelect(textQuery.Text);
                    break;
                case "Insert":
                    if(sqlInsert(textQuery.Text))
                    displayBox.Text = "Insert completed sucessfuly";
                    break;
                case "Update":
                    if(sqlUpdate(textQuery.Text))
                    displayBox.Text = "Update completed sucessfuly";
                    break;
                default:
                    MessageBox.Show("Invalid Query");
                    break;
            }
            

        }
    }
}
