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
    public partial class Form3 : Form
    {
        String connection;
        Form2 secondForm;


        public Form3(Form2 f2)
        {
            secondForm = f2;
            InitializeComponent();
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            connection = connString.Text;
            secondForm.connectionString = connection;
            this.Close();
        }
        
    }
}
