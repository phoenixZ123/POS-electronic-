using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Store
{
    public partial class Register : Form
    {
        private readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";


        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Regex rg = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
            Regex pa = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");           
           

            bool isValid = rg.IsMatch(txtemail.Text);
            bool pass = pa.IsMatch(txtpass.Text);
            if (isValid && pass)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(_connectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Register values(@email,@username,@password)", conn);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);         
                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    cmd.ExecuteNonQuery();

                    LoginForm lf=new LoginForm();
                    lf.ShowDialog();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please try again");
            }
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
        }
    }
}
