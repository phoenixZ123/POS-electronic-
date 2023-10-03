using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Store
{
    public partial class LoginForm : Form
    {
        //Data Source = localhost; Initial Catalog = master; User ID = sa; Password=ComplexPassword123!;Connect Timeout = 30; Encrypt=False;
        //Data Source =
        private readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count (*) from Register where username=@usr and password=@pwd", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", txtuser.Text);
            cmd.Parameters.AddWithValue("@pwd", txtpass.Text);


            if(txtuser.Text=="" || txtpass.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    Dashboard db = new Dashboard();
                    db.Username = txtuser.Text;
                    db.ShowDialog();
                   

                    // db.ShowDialog();
                }
                else
                {
                    tryagain.Text = "please enter correct information";
                    tryagain.BackColor = Color.Red;
                }
            }
           


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
        }

        private void btnforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {          
            Change_Password f = new Change_Password();
            f.Show();
        }
    }
}
