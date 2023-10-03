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


namespace Electronic_Store.components
{
    public partial class AddProducts : UserControl
    {
        List<Model> model = new List<Model>();
        List<Category> category = new List<Category>();
        private readonly string _connectionString = @"Data Source = localhost;Initial Catalog = Electronic_Store;User ID=sa;Password=ComplexPassword123!;Connect Timeout =30;Encrypt=False;";

        public AddProducts()
        {
            InitializeComponent();

        }

        private void AddCategoryModel()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Category values(@cate)", conn);
            cmd.Parameters.AddWithValue("@cate", txtCate.Text);
            //cmd.Parameters.AddWithValue("@stan", txtStandard.Text);
           // SqlCommand cmd2 = new SqlCommand("insert into Standard values(@stan)", conn);
           // cmd2.Parameters.AddWithValue("@stan", txtStandard.Text);
            cmd.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added Complete");
            txtCate.Text = "";
            GetComboCateCell();
        }
        private void btnAddCate_Click(object sender, EventArgs e)
        {
            GetData();
            AddCategoryModel();
            GetCategory();
        }
       
        private void GetCategory()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select * from Category", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            DataSet dsd = new DataSet();
            ada.Fill(dsd, "Category");
           
            comboCategory.SelectedIndexChanged -= new EventHandler(this.comboCategory_SelectedIndexChanged);
            comboCategory.DataSource = dsd.Tables[0];
            comboCategory.DisplayMember = "Category";
            comboCategory.ValueMember = "CateId";
            comboCategory.SelectedIndexChanged += new EventHandler(this.comboCategory_SelectedIndexChanged);

            conn.Close();
           
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
        private void GetBrandNameCombobox()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select * from Brand", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            DataSet dsd = new DataSet();
            ada.Fill(dsd, "Brand");
            comboBrand.DataSource = dsd.Tables[0];
            comboBrand.DisplayMember = "BrandName";
            comboBrand.ValueMember = "BrandId";
            conn.Close();

        }
        private void GetData()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Item.ModelNo,Category.Category,Item.BrandName,Item.ItemType,Item.Quantity,Item.Price,Item.Date from Category inner join Item on Category.CateId=Item.CateId", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            DataTable dt = new DataTable();
            dt = ds.Tables["Category"];

            dataView.DataSource = dt;

            conn.Close();
            //blank
            txtType.Text = "";
            comboBrand.SelectedItem = null;
            comboCategory.SelectedItem = null;
            dataTimePicker1.Text = "";
            txtQuan.Text = "";
            txtPrice.Text = "";
            txtModel.Text = "";

            labelrow.Text = "Total Records : " + dt.Rows.Count.ToString() + " items";
        }
        private void getByModelSearch()
        {
            //
        }
        //
        private string[] GetModelById(int id)
        {
            return model.Where(fun => fun.cate_id == id).Select(value => value.modelno).ToArray();
        }
        private void GetComboCateCell()
        {
            GetCategory();          
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select * from Category", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(ada);
            DataSet dsd = new DataSet();
            ada.Fill(dsd, "Category");
           
            comboCateCell.SelectedIndexChanged -= new EventHandler(this.comboCategory_SelectedIndexChanged);
            comboCateCell.DataSource = dsd.Tables[0];
            comboCateCell.DisplayMember = "Category";
            comboCateCell.ValueMember = "CateId";
            comboCateCell.SelectedIndexChanged += new EventHandler(this.comboCategory_SelectedIndexChanged);
            conn.Close();
            
        }
        private void AddProducts_Load(object sender, EventArgs e)
        {
           
            comboBrand.Items.Clear();
            comboCategory.Items.Clear();
            dataTimePicker1.Text = "";
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            GetData();
            SqlCommand cmd1 = new SqlCommand("select * from Category", conn);
            SqlDataReader rdr = cmd1.ExecuteReader();
            while (rdr.Read())
            {
                comboCateCell.Items.Add(rdr["Category"]);
                category.Add(new Category()
                {
                    id = ((int)rdr["CateId"]),
                    category_name = rdr["Category"].ToString()
                });
            }
            rdr.Close();
            cmd1.ExecuteNonQuery();
            //conn.Close();
            //        
            //conn.Open();
            SqlCommand cmdd = new SqlCommand("select * from Model", conn);
            SqlDataReader rdrr = cmdd.ExecuteReader();
            while (rdrr.Read())
            {

                model.Add(new Model()
                {
                    Id = ((int)rdrr["Id"]),
                    modelno = rdrr["Model_no"].ToString(),
                    cate_id = ((int)rdrr["CateId"])
                });
            }
            rdrr.Close();
            cmdd.ExecuteNonQuery();
            conn.Close();

            GetData();
            GetCategory();
            GetComboCateCell();
            GetBrandNameCombobox();


        }

        private void getEnter()
        {
            if (comboCategory.SelectedIndex == -1) return;

            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            //SqlCommand cmd = new SqlCommand("select CateId from Category where Category.Category='" + comboCategory.SelectedValue + "'", con);
            //SqlCommand cmd2 = new SqlCommand("select Standard_no from Standard where SId='" + Convert.ToInt32(cmd.ExecuteScalar().ToString()) + "'", con);
            SqlCommand cmd2 = new SqlCommand("select Standard_no from Category where CateId=@id", con);
            cmd2.Parameters.AddWithValue("@id", comboCategory.SelectedValue);
            string standard_no = cmd2.ExecuteScalar().ToString();
            //int id = Convert.ToInt32(comboCategory.SelectedValue.ToString());
            //SqlCommand Standard = new SqlCommand("select Standard_no from Standard where SId='" + id + "'", con);
            txtModel.Text = standard_no;
            //Standard.ExecuteNonQuery();
            con.Close();

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //getEnter();

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void AddBrand()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();         
            SqlCommand cmd = new SqlCommand("insert into Brand values(@brand)", con);
            cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Brand Name Added");
            txtBrand.Text = "";
        }
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand();
            GetBrandNameCombobox();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();

            if(comboCategory.Text==""|| txtModel.Text==""|| dataTimePicker1.Text==""||comboBrand.Text==""||txtType.Text==""|| txtQuan.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please Enter Your Product Information", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("insert into Model values(@modno,@cateId)", con);
                cmd2.Parameters.AddWithValue("@modno", txtModel.Text);
                cmd2.Parameters.AddWithValue("@cateId", Convert.ToInt32(comboCategory.SelectedValue.ToString()));
                SqlCommand cmd = new SqlCommand("insert into Item values(@modelno,@cateid,@brand,@type,@quan,@price,@date)", con);
                cmd.Parameters.AddWithValue("@modelno", txtModel.Text);
                int cateid = Convert.ToInt32(comboCategory.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@cateid", cateid);
                cmd.Parameters.AddWithValue("@brand", comboBrand.Text);
                cmd.Parameters.AddWithValue("@type", txtType.Text);
                //cmd.Parameters.AddWithValue("@spec", txtSpec.Text);
                int quantity = Convert.ToInt32(txtQuan.Text.ToString());
                ; cmd.Parameters.AddWithValue("@quan", quantity);
                int price = Convert.ToInt32(txtPrice.Text.ToString());
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@date", dataTimePicker1.Text);

                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complete Item Inserted");
                GetData();
            }
            //at model table
           
            con.Close();
            GetCateCell();
            GetComboCateCell();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit edit = new Edit();
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();


            //string type = this.dataView.CurrentRow.Cells[3].Value.ToString();
            //SqlCommand cmd = new SqlCommand("select ModelNo from Item where ItemType='" + type + "'", con);
            //int no = Convert.ToInt32(cmd.ExecuteScalar());

            //edit.idtext = cmd.ExecuteScalar().ToString();

            edit.brand = this.dataView.CurrentRow.Cells[2].Value.ToString();
            edit.category = this.dataView.CurrentRow.Cells[1].Value.ToString();
            edit.type = this.dataView.CurrentRow.Cells[3].Value.ToString();
            edit.quantity = this.dataView.CurrentRow.Cells[4].Value.ToString();
            edit.price = this.dataView.CurrentRow.Cells[5].Value.ToString();
            edit.date = this.dataView.CurrentRow.Cells[6].Value.ToString();
            edit.mno = this.dataView.CurrentRow.Cells[0].Value.ToString();
            edit.ShowDialog();
            con.Close();
            GetData();
        }
      
        private void GetCateCell()
        {
            comboModelCell.Items.Clear();
            GetCategory();


            int id = category[comboCateCell.SelectedIndex].id;
            foreach (string name in GetModelById(id))
            {
                this.comboModelCell.Items.Add(name);

            }
        }
        private void comboCateCell_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCateCell();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           // getEnter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            comboCateCell.Text = "";
            comboModelCell.Text = "";
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            if(comboCateCell.SelectedIndex>=0 || comboModelCell.SelectedIndex > 0)
            {              
                SqlDataAdapter da = new SqlDataAdapter("select Item.ModelNo, Category.Category, Item.BrandName, Item.ItemType, Item.Quantity, Item.Price, Item.Date from Category inner join Item on Category.CateId = Item.CateId where Item.ModelNo='" + comboModelCell.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Category");
                DataTable dt = new DataTable();
                dt = ds.Tables["Category"];

                dataView.DataSource = dt;
                
                labelrow.Text = "Total Records : " + dt.Rows.Count.ToString() + " items";
               
            }
            else
            {
                MessageBox.Show("Select You Want To Search By Category and Model Number");
            }
           
            con.Close();
          
           
        }

        private void btnAll_Click(object sender, EventArgs e)
        {            
            GetData();
            GetCategory();

            comboCategory.Text = "";
            comboBrand.Text = "";
            //comboModelCell.Items.Clear();

        }

        private void comboModelCell_SelectedIndexChanged(object sender, EventArgs e)
        {
            // GetData();
            GetComboCateCell();

        }

        private void btnExport_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dataView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
    [Serializable]
    class Category
    {
        public int id { get; set; }
        public string category_name { get; set; }
    }

    [Serializable]
    class Model
    {
        public int Id { get; set; }
        public string modelno { get; set; }
        public int cate_id { get; set; }

    }
}
