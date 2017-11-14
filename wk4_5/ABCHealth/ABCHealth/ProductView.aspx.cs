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
            //List<Product> prodAll = new List<Product>();

            //prodAll = prodBLL.GetAllProduct();

            //gvProduct.DataSource = prodAll;
            //gvProduct.DataBind();
            if (!IsPostBack)
            {
                bind();
            }
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
            decimal prodID = decimal.Parse(gvProduct.DataKeys[e.RowIndex].Value.ToString());
            int rowleft = prodBLL.ProductDelete(prodID);

            // Response message 
            Response.Redirect("<scrit>alert('Data delete successfully')</script>");
        }

        protected void gvProduct_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProduct.EditIndex = e.NewEditIndex;
            bind();
        }

        protected void gvProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ProductBLL pBll = new ProductBLL();

            GridViewRow row = (GridViewRow)gvProduct.Rows[e.RowIndex];
            decimal id = decimal.Parse(gvProduct.DataKeys[e.RowIndex].Value.ToString());
            string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
            string tname = ((TextBox)row.Cells[2].Controls[0]).Text;
            string tprice =((TextBox)row.Cells[3].Controls[0]).Text;

            pBll.ProductUpdate(tid, tname, tprice);
            gvProduct.EditIndex = -1;
            bind();
        }

        protected void gvProduct_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProduct.EditIndex = -1;
            bind();
        }
        protected void bind()
        {
            List<Product> prodAll = new List<Product>();
            prodAll = prodBLL.GetAllProduct();

            gvProduct.DataSource = prodAll;
            gvProduct.DataBind();
        }
    }
}