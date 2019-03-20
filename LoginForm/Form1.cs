using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KHALID\MSSQLSERVER12;Initial Catalog=KHALID;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where USER='"+ textBox1.Text +"' and PASS='"+ textBox2.Text +"'", con);
            DataTable dt = new DataTable();            
            sda.Fill(dt); 
            if (dt.Rows[0][0].ToString() == "1")
            {
                Main mn = new Main();
                mn.Show();
            }
            else
            {
                MessageBox.Show("invalid login details");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
