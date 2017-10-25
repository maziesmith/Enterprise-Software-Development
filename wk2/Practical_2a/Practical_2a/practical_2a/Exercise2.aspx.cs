using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_2a
{
    public partial class Exercise2 : System.Web.UI.Page
    {
        private static double amountDue;
        private static int totalQuantity;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void updateSelection()
        {
            string sSize = rbSize.SelectedIndex.ToString(); //retrieve size selection
            int Size = Convert.ToInt32(sSize);

            bool isLite = cbLite.Checked;                   //retrieve extra selection
            bool isEnergyBooster = cbEnergyBooster.Checked;
            bool isVitaminPack = cbVitaminPack.Checked;
            double itemPrice = 0.0;

            if (Size == 12)
            {
                itemPrice = 3.0;                            //calculating item price
            }
            else if (Size == 16)
            {
                itemPrice = 3.5;
            }
            else
            {
                itemPrice = 4;
            }
            if (isLite)
            {
                itemPrice += 0.5;
            }
            if (isEnergyBooster)
            {
                itemPrice += 0.5;
            }
            if (isVitaminPack)
            {
                itemPrice += 0.5;
            }

            lblPrice.Text = "$" + itemPrice.ToString();

            int qtyOrder = 1;
            try
            {
                qtyOrder = Convert.ToInt32(txtQty.Text);
            }
            catch (FormatException fe)
            {
                Response.Write("<script>alert('Must be numeric');</script>");
            }
            if (Session["amountDue"] == null)
            {
                amountDue = amountDue + (qtyOrder * itemPrice);  //updating amount due
            }
            else
            {
                amountDue = Convert.ToDouble(Session["amountDue"]);
                amountDue += qtyOrder * itemPrice;
            }
            Session["amountDue"] = amountDue;
            lblAmountDue.Text = amountDue.ToString();

            if (Session["totalQuantity"] == null)
            {
                totalQuantity = qtyOrder;
            }
            else
            {
                totalQuantity = Convert.ToInt32(Session["totalQuantity"]);
                totalQuantity += qtyOrder;
            }
            Session["totalQuantity"] = totalQuantity;
        }

        protected void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            updateSelection();
        }

        protected void btnSummaryReport_Click(object sender, EventArgs e)
        {
            if ((Session["totalQuantity"]) != null && (Session["amountDue"]) != null)
            {
                totalQuantity = Convert.ToInt32(Session["totalQuantity"]);
                amountDue = Convert.ToDouble(Session["amountDue"]);
            }
            string report = @"******* Juice Bar Sales Summary *******

            Total Drink Order: " + totalQuantity.ToString() + @"
            Total Amount Due: " + amountDue.ToString();

            txtSummary.Text = report;
        }

        protected void rbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void rbDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cbVitaminPack_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}