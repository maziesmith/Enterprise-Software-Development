using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace ABCHealth
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        ProductBLL productBLL = new ProductBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get Product ID from querystring 
            string prodID = Request.QueryString["ProdID"].ToString();

            // Convert Product ID to Decimal 
            decimal dProdID = decimal.Parse(prodID);

            // Create a product object 
            Product prod = null;

            // Call getProdDetail() method 
            prod = productBLL.GetProdDetail(dProdID);

            // Display product details on web form 
            lbl_ProdName.Text = prod.Product_Name;
            lbl_ProdDesc.Text = prod.Product_Desc;
            lbl_Price.Text = prod.Unit_Price.ToString("c");
            img_Product.ImageUrl = "~\\Images\\" + prod.Product_Image;

            // Store the value in invisible fields 
            lbl_Price.Text = prod.Unit_Price.ToString();
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductView.aspx");
        }

        protected void btn_Add_To_Cart_Click(object sender, EventArgs e)
        {

        }
    }
}