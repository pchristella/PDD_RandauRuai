using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace PDD_RandauRuai
{
    public partial class _Default : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_dept.Text = "";
            txt_telno.Text = "";

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            bool stat = false;

            lbl_error.Visible = false;

            try
            {
                if (txt_id.Text != "")
                {
                    txt_name.Text = "";
                    txt_dept.Text = "";
                    txt_telno.Text = "";

                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM randau_ruai.staff WHERE idstaff = '" + txt_id.Text + "'";
                    cmd.Connection = conn;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows == true)
                        {
                            txt_name.Text = dr["name"].ToString();
                            txt_dept.Text = dr["dept"].ToString();
                            txt_telno.Text = dr["telno"].ToString();

                            stat = true;
                        }
                    }

                    if (stat == false)
                    {
                        lbl_error.Text = "ID not found. Please insert details below.";
                        lbl_error.Visible = true;
                        txt_name.Enabled = true;
                        txt_dept.Enabled = true;
                        txt_telno.Enabled = true;
                    }
                    else
                    {
                        txt_name.Enabled = false;
                        txt_dept.Enabled = false;
                        txt_telno.Enabled = true;
                    }
                }
                else
                {
                    lbl_error.Text = "Please Insert Staff ID!";
                    lbl_error.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            bool stat = false;
            /*---------CHECK IC--------------*/
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM randau_ruai.staff WHERE idstaff = '" + txt_id.Text + "'";
                cmd.Connection = conn;

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        stat = true;
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
            /*----------INSERT/UPDATE DETAILS-------------*/
            try
            {
                conn.Open();

                if (stat == false)
                {
                    if (txt_name.Text != "" && txt_telno.Text != "")
                    {
                        MySqlCommand cmd4 = new MySqlCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.CommandText = "INSERT INTO staff (idstaff, name, dept, telno) VALUES ('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_dept.Text + "','" + txt_telno.Text + "')";
                        cmd4.Connection = conn;

                        cmd4.ExecuteNonQuery();
                    }
                    else
                    {
                        if (txt_name.Text == "" && txt_telno.Text != "") { lbl_error.Text = "Please Insert Name!"; }
                        if (txt_name.Text != "" && txt_telno.Text == "") { lbl_error.Text = "Please Insert Phone Number!"; }
                        if (txt_name.Text == "" && txt_telno.Text == "") { lbl_error.Text = "Please Insert Name & Phone Number!"; }

                        lbl_error.Visible = true;
                    }
                }
                else
                {
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE staff SET name='" + txt_name.Text + "', dept='" + txt_dept.Text + "', telno = '" + txt_telno.Text + "', checkout_dt=NOW() WHERE idstaff = '" + txt_id.Text + "'";
                    cmd2.Connection = conn;

                    cmd2.ExecuteNonQuery();

                    lbl_error.Text = "SUCCESSFULLY CHECKED IN! ENJOY THE RANDAU RUAI!";
                    lbl_error.Visible = true;
                    lbl_error.ForeColor = System.Drawing.Color.Black;
                    clear();

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Module/LuckyDraw/RR_luckydraw_main.aspx");
        }
    }
}