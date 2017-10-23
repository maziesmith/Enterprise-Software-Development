using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1b
{
    public partial class Ex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncompute_Click(object sender, EventArgs e)
        {
            // Initialise n1 and n2 
            Double n1 = 0;
            Double n2 = 0;

            // Read n1 and n2 from the textbox 
            try
            {
                n1 = Convert.ToDouble(tbn1.Text);
                n2 = Convert.ToDouble(tbn2.Text);
            }
            catch (FormatException fe)
            {
                Response.Write("<script>alert('Only numbers allowed')</script>");
            }

            // Compute sum, average, min and max
            Double sum = n1 + n2;
            Double avg = sum / 2;
            Double max = System.Math.Max(n1, n2);
            Double min = System.Math.Min(n1, n2);

            // Put results in labels 
            lblsum.Text = sum.ToString();
            lblavg.Text = avg.ToString();
            lblmax.Text = max.ToString();
            lblmin.Text = min.ToString();
        }
    }
}