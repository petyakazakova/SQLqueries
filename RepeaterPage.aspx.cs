﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace MasterAndTheme
{
    public partial class RepeaterPage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = Catdb");
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        string sqlsel = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterCat.DataBind();
            LabelMessage.Text = "No error message";
        }

        public void ShowMyData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);

                rdr = cmd.ExecuteReader();
                RepeaterCat.DataSource = rdr;
                RepeaterCat.DataBind();
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            sqlsel = "select * from cat";
            ShowMyData();
        }
    }
}