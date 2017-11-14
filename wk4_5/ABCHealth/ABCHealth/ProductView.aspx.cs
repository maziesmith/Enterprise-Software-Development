using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABCHealth
{
    public partial class ProductView : System.Web.UI.Page
    {
        ProductBLL prodBLL = new ProductBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> prodAll = new List<Product>();

            prodAll = prodBLL.GetAllProduct();

            gvProduct.DataSource = prodAll;
            gvProduct.DataBind();
        }

        protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected row. 
            GridViewRow row = gvProduct.SelectedRow;

            // Get Product ID from the selected row, which is the 
            // first row, i.e. index 0.
            string prodID = row.Cells[0].Text;

            // Redirect to next page, with the Product ID added to the URL, 
            // e.g. ProductDetails.aspx?ProdID=1
            Response.Redirect("ProductDetails.aspx?ProdID=" + prodID);
        }

        protected void gvProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //decimal id = decimal.Parse(gvProduct.DataKeyNames[e.RowIndex].Value.ToString());

            // Get current selected row 
            GridViewRow row = gvProduct.Rows[e.RowIndex];
            
            // Get ProductID from selected row 
            decimal prodID = decimal.Parse(row.Cells[0].Text);
            int rowleft = prodBLL.ProductDelete(prodID);

            // Response message 
            Response.Redirect("<scrit>alert('Data Save successfully')</script>");
        }
    }
}