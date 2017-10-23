using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PDD_RandauRuai.Module.LuckyDraw
{
    public partial class RR_luckydraw_loading : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
          Response.Redirect("RR_luckydraw_result_staff.aspx");
        }
    }
}