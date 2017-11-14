using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_2a.Account
{
    public partial class Exercise1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncal_Click(object sender, EventArgs e)
        {
            // Will to live 

            // Determine BMI category 
            string bmistatus, bmiremark;
            double weight = 0, height = 0, bmi = 0;

            try
            {
                weight = Convert.ToDouble(tbweight.Text);
                height = Convert.ToDouble(tbheight.Text);
            }
            catch (FormatException fe)
            {
                // Error 
                Response.Write("<script>alert('Error format exception')</script>");
            }


            bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                bmistatus = "You are underweight.";
                bmiremark = "Your bmi is " + bmi;
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmistatus = "You are normal weight";
                bmiremark = "Your bmi is " + bmi;
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                bmistatus = "You are overweight";
                bmiremark = "Your bmi is " + bmi;
            }
            else
            {
                bmistatus = "You are obese";
                bmiremark = "Your bmi is " + bmi;
            }
            lblstatus.Text = bmistatus;
            lblbmi.Text = bmiremark;
        }
    }
}