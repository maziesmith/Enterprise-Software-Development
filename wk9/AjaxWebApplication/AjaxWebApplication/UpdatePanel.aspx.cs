using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxWebApplication
{
    public partial class UpdatePanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblPageLoad.Text = DateTime.Now.ToString();
        }

        protected void btnOutsideUpdatePanel_Click(object sender, EventArgs e)
        {
            this.lblOutsideUpdatePanel.Text = DateTime.Now.ToString();
        }

        protected void btnUpdatePanel_Click(object sender, EventArgs e)
        {
            this.lblInsideUpdatePanel.Text = DateTime.Now.ToString();
        }
    }
}