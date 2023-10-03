using Electronic_Store.Actions;
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


using View = Electronic_Store.Actions.View;

namespace Electronic_Store.components
{
    public partial class SoldProducts : UserControl
    {
        public readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";
        public SoldProducts()
        {
            InitializeComponent();
        }

        private void GetSold()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ModelNo,Category,ItemType,BrandName,Quantity,Price,Date from Sold", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sold");
            DataTable dt = new DataTable();
            dt = ds.Tables["Sold"];

            dataGridView1.DataSource = dt;

            conn.Close();
            lblsold.Text = "Total Records : " + dt.Rows.Count.ToString() + " items";

        }

        private void GetEmptyquantity()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            int quan = 0;
            SqlDataAdapter da = new SqlDataAdapter("select Item.ModelNo,Category.Category,Item.BrandName,Item.ItemType,Item.Price,Item.Date from Category inner join Item on Category.CateId=Item.CateId where Item.Quantity=" + quan + "", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            DataTable dt = new DataTable();
            dt = ds.Tables["Category"];

            dataGridView2.DataSource = dt;

            conn.Close();
            lbldrop.Text = "Total Records : " + dt.Rows.Count.ToString() + " items";
            GetSold();
        }
        private void SoldProducts_Load(object sender, EventArgs e)
        {
            GetSold();
            GetEmptyquantity();
            //
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Price from Sold", conn);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                int price = 0;
                while (dr.Read())
                {
                    int readprice = Convert.ToInt32(dr["Price"].ToString());
                    price = price + readprice;
                }
                dr.Close();
                cmd.ExecuteNonQuery();
                totalsaleprice.Text = "Total Selling Price : " + price;
            }

            conn.Close();
            //
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetEmptyquantity();
            GetSold();

        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select ModelNo,Category,ItemType,BrandName,Quantity,Price,Date from Sold where Date between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            View view = new View();
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            view.type = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            view.model = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            view.date = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            view.ShowDialog();
            con.Close();
            GetSold();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empty emp = new Empty();           
            emp.type = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            emp.model= this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            emp.ShowDialog();
            GetEmptyquantity();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();

        }

        private void ExportEmptyItem_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
