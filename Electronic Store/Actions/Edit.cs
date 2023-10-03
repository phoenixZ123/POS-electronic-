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
    public partial class Edit : Form
    {
        private readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";

        internal object lblBrand;

        public Edit()
        {
            InitializeComponent();
        }

        public string idtext { get; set; }
        public string category { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }
        public string date { get; set; }
        public string mno { get; set; }


        private void Edit_Load(object sender, EventArgs e)
        {
            // txtId.Text = idtext;
            txtBrand.Text = brand;
            txtCate.Text = category;
            txtType.Text = type;
            txtQuan.Text = quantity;
            lblTotal.Text = quantity;
            txtPrice.Text = price;
            dateSold.Text = date;
            modelno.Text = mno;
            //
            total.Text = "0";
        }

        private void Delete()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("delete from Item where ModelNo=@model", con);
            SqlCommand cmd2 = new SqlCommand("delete from Model where Model_no=@no", con);
            cmd2.Parameters.AddWithValue("@no", modelno.Text.ToString());
            cmd1.Parameters.AddWithValue("@model", modelno.Text.ToString());
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
            MessageBox.Show("deleted");
            this.Close();
        }

        private int Update()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Item set Quantity=@quan,Price=@price,Date=@date where ModelNo=@mno", con);

            cmd.Parameters.AddWithValue("@mno", modelno.Text.ToString());
            cmd.Parameters.AddWithValue("@date", dateSold.Text.ToString());
            cmd.Parameters.AddWithValue("@quan", txtQuan.Text.ToString());
            cmd.Parameters.AddWithValue("@price", txtPrice.Text.ToString());
            int result = cmd.ExecuteNonQuery();
            con.Close();

            return result;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int result2 = Update();
            string message = result2 > 0 ? "Updating successful" : "fail";
            MessageBox.Show(message);
            this.Close();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuan.Text.ToString());
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            SqlCommand itemquan = new SqlCommand("select Quantity from Item where ModelNo=@model", con);
            itemquan.Parameters.AddWithValue("@model", modelno.Text.ToString());
            int iquan = Convert.ToInt16(itemquan.ExecuteScalar().ToString());
            if (txtQuan.Text == "0" || quantity>iquan)
            {
                MessageBox.Show("Not Enough Quantity");
            }
            else
            {
                
                SqlCommand cmd = new SqlCommand("insert into Sold values(@modelno,@cate,@ItemType,@BrandName,@Quantity,@Price,@Date)", con);
                cmd.Parameters.AddWithValue("@modelno", modelno.Text.ToString());
                cmd.Parameters.AddWithValue("@cate", txtCate.Text.ToString());
                cmd.Parameters.AddWithValue("@BrandName", txtBrand.Text.ToString());
                cmd.Parameters.AddWithValue("@ItemType", txtType.Text.ToString());
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                SqlCommand price = new SqlCommand("select Price from Item where ModelNo=@no", con);
                price.Parameters.AddWithValue("@no", modelno.Text.ToString());
                int orgprice = int.Parse(price.ExecuteScalar().ToString());
                int tprice = quantity * orgprice;
                cmd.Parameters.AddWithValue("@Price", tprice);
                cmd.Parameters.AddWithValue("@Date", dateSold.Text.ToString());
                cmd.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("select Quantity from Item where ModelNo=@model", con);
                cmd3.Parameters.AddWithValue("@model", modelno.Text.ToString());
                int quan = int.Parse(cmd3.ExecuteScalar().ToString());
                int lastquan = quan - quantity;
                SqlCommand cmd4 = new SqlCommand("update Item set Quantity=@quan where ModelNo=@model", con);
                cmd4.Parameters.AddWithValue("@model", modelno.Text.ToString());
                cmd4.Parameters.AddWithValue("@quan", lastquan);
                cmd4.ExecuteNonQuery();

                MessageBox.Show("Added As Sold Item");
            }
            //


            con.Close();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();

            string mno = modelno.Text.ToString();
            SqlCommand cmd = new SqlCommand("select Price from Item where ModelNo='" + mno + "'", con);
            string pri = cmd.ExecuteScalar().ToString();
            int price = Convert.ToInt32(pri);
            int quantity = Convert.ToInt32(txtQuan.Text.ToString());
            int result = price * quantity;
            total.Text = result.ToString();
            txtPrice.Text = result.ToString();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
