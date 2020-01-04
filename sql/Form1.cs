using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sql
{
    public partial class Form1 : Form
    {

        //Map of valid users
        Dictionary<string, string> users = new Dictionary<string, string>();

        //See if user is trying to access with good email/pass
        private bool haveAccess()
        {
            foreach (KeyValuePair<string, string> user in users)
            {
                if (inputEmail.Text.Equals(user.Key) && inputPass.Text.Equals(user.Value))
                    return true;
            }    
            return false;
        }

        //Adding users to map
        private void addUsers()
        {
            users.Add("tin@gmail.com", "password");
            users.Add("admin", "admin");
        }
        
        //Constructor
        public Form1()
        {
            InitializeComponent();
            addUsers();
        }


        //Go to next form if user have good credentials
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







        /*------------------------------------
        Unused methods
        Needs to be deleted.
             
        ---------------------------------------*/
        //NEED TO DELETE
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //NEED TO DELETE
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //NEED TO DELETE
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
