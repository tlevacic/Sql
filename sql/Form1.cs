using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO 1: add one line input (email and pass)
//TODO 2: password input validate
//TODO 3: modify text in inputs
namespace sql
{
    public partial class Form1 : Form
    {

        //Map of valid users
        Dictionary<string, string> users = new Dictionary<string, string>();


        private bool haveAccess()
        {
            foreach (KeyValuePair<string, string> user in users)
            {
                if (inputEmail.Text.Equals(user.Key) && inputPass.Text.Equals(user.Value))
                    return true;
            }    
            return false;
        }

        private void addUsers()
        {
            users.Add("tin@gmail.com", "password");
            users.Add("admin", "admin");
        }

        public Form1()
        {
            InitializeComponent();
            addUsers();
        }
        //NEED TO DELETE
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //NEED TO DELETE
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Go to next form
        private void button2_Click(object sender, EventArgs e)
        {
            if (haveAccess())
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
            }
            else
                MessageBox.Show("Wrong Credentials!");
                

        }

        //Close form1
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
