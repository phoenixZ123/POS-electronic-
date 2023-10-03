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

namespace Electronic_Store.Actions
{
    public partial class View : Form
    {
        public readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";

        public View()
        {
            InitializeComponent();
        }

        public string type { get; set; }
        public string model { get; set; }
        public string date { get; set; }

        private void View_Load(object sender, EventArgs e)
        {
            Type.Text = type;
            lblModel.Text= model;
            lblDate.Text = date;          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Sold where ModelNo=@model and Date=@date", con);
            cmd.Parameters.AddWithValue("@model", lblModel.Text.ToString());
            cmd.Parameters.AddWithValue("@date",lblDate.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Sold Item");
            this.Close();
        }
    }
}
