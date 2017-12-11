using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxWebApplication
{
    public partial class UpdatePanelTrigger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateBoth_Click(object sender, EventArgs e)
        {
            this.Label2.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
            this.Label4.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }

        protected void btnUpdateThis_Click(object sender, EventArgs e)
        {
            this.Label2.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }
    }
}