using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace MasterAndTheme
{
    public partial class DBpage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Northwind");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        string sqlsel = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewNorthwind.DataBind();
            LabelMesage.Text = "No error message";
        }

        public void ShowMyData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                rdr = cmd.ExecuteReader();
                GridViewNorthwind.DataSource = rdr;
                GridViewNorthwind.DataBind();
            }
            catch (Exception ex)
            {
                LabelMesage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            //sqlsel = "select top 10 * from products";

            //Join relational tables:
            //sqlsel = "select productname, companyname from products, suppliers where products.supplierid = suppliers.supplierid";
            //sqlsel = "select products.productname, suppliers.companyname from products inner join suppliers on products.supplierid = suppliers.supplierid";
           
            //sqlsel = "select top 10 products.productid, products.productname, categories.categoryname, suppliers.companyname from products, categories, suppliers where products.supplierid = suppliers.supplierid and products.categoryid = categories.categoryid order by products.productid";
            
            //sqlsel = "select * from products where productname like '%ost%' order by unitsinstock desc";

            //sqlsel = "select distinct country as Nations from suppliers order by country";
            ShowMyData();
        }
    }
}