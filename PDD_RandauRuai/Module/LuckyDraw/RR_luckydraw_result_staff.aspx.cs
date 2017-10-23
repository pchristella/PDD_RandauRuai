﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace PDD_RandauRuai.Module.LuckyDraw
{
    public partial class RR_luckydraw_result_staff : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM staff WHERE luckydraw_st = 0 AND checkout_dt IS NOT NULL ORDER BY RAND() LIMIT 1";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        Label1.Text = dr["idstaff"].ToString();
                        Label2.Text = dr["name"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE staff SET luckydraw_st=1 WHERE idstaff = '" + Label1.Text + "'";
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("RR_luckydraw_main.aspx");
        }
    }
}