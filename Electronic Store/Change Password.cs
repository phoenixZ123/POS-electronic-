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

namespace Electronic_Store
{
    public partial class Change_Password : Form
    {
        private readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";

        public Change_Password()
        {
            InitializeComponent();
        }

        private void Forgot_Password_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            if (txtemail.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Enter your information");

            }
            else
            {                          
                //update
                SqlCommand cmdchange = new SqlCommand("update Register set password=@pass where email=@email", conn);
                cmdchange.Parameters.AddWithValue("@email", txtemail.Text);
                cmdchange.Parameters.AddWithValue("@pass", txtpass.Text);
                cmdchange.ExecuteNonQuery();
                MessageBox.Show("Complete Your Password Changing");
                LoginForm lg = new LoginForm();
                lg.Show();
            }
            conn.Close();
           

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
        }
    }
}
