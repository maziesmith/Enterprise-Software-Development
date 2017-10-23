using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1b
{
    public partial class Ex3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Double itemPrice = 0;
            try
            {
                itemPrice = Convert.ToDouble(tbprice.Text);
            }
            catch (FormatException fe)
            {
                Response.Write("<script>alert('Only numbers allowed')</script>");
            }
            Double total = 0;
            // check whether total is in the session 
            if(Session["Total"] != null)
            {
                try
                {
                    total = Convert.ToDouble(Session["Total"].ToString());
                }
                catch (FormatException fe)
                {
                    total = 0;
                }
            }
            total = total + itemPrice;
            Session["Total"] = total.ToString();
            lbltotal.Text = total.ToString();
        }
    }
}