using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1b
{
    public partial class Ex2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngo_Click(object sender, EventArgs e)
        {
            String word = "";
            String message = "";

            word = tbword.Text;
            int repeat = 0;

            try
            {
                repeat = Convert.ToInt32(tbno.Text);
            }
            catch( FormatException fe)
            {
                Response.Write("<script>alert('Only numbers allowed')</script>");
            }
            for (int i=0; i<repeat; i++)
            {
                message = message + word;
            }
            lblrepeat.Text = message;
        }
    }
}