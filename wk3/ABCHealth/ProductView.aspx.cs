using System;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        GridViewRow row = gvProduct.SelectedRow;

        string prodID = row.Cells[0].Text;
        Response.Redirect("ProductDetails.aspx?ProdID=" + prodID);
    }
}