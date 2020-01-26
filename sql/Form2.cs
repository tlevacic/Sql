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
        public String connectionString;
        SqlConnection cnn = new SqlConnection();

        //Constructor
        public Form2()
        {
            InitializeComponent();
        }
    

        //Insert query
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

        //Update query
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

        //Delete query
        private bool sqlDelete(string query)
        {
            try
            {
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                cmd = new SqlCommand(query, cnn);
                adapter.DeleteCommand = new SqlCommand(query, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Delete not completed. Please try again.");
                return false;
            }
        }

        //Select query
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
                                    outputString = outputString + reader[i] + "   ";
                                }
                                outputString += "\n";

                            }
                        }
                    } // reader closed

                }
            }
            catch
            {
                MessageBox.Show("Invalid SELECT !");

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
                if (cnn != null && cnn.State == ConnectionState.Closed)
                {
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    setConnBtn.Visible = false;
                    setConnBtn.BackColor = Color.FromArgb(37, 37, 37);                   
                    connectionInfo.Text = "You Are Connected";
                    connectionBtn.Visible = false;
                    connectionInfo.ForeColor = Color.FromArgb(92, 230, 71);
                }
            }
            catch(System.InvalidOperationException)
            {
                MessageBox.Show("Something gone wrong");
            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("Wrong connection string!");
            }
        }

        //Find out what query needs to be called
        private void execute_Click(object sender, EventArgs e)
        {
            switch (textQuery.Text.Split(' ')[0].ToLower())
            {
                case "select":
                    displayBox.Text = sqlSelect(textQuery.Text);
                    break;
                case "insert":
                    if(sqlInsert(textQuery.Text))
                    displayBox.Text = "Insert completed sucessfuly";
                    break;
                case "update":
                    if(sqlUpdate(textQuery.Text))
                    displayBox.Text = "Update completed sucessfuly";
                    break;
                case "delete":
                    if (sqlUpdate(textQuery.Text))
                        displayBox.Text = "Delete completed sucessfuly";
                    break;
                default:
                    MessageBox.Show("Invalid Query");
                    break;
            }
            

        }

        //Clear query input & query res
        private void clearBtn_Click(object sender, EventArgs e)
        {
            textQuery.Text = "";
            displayBox.Text = "";
        }

        //Set connection string
        private void setConnBtn_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }
    }
}
