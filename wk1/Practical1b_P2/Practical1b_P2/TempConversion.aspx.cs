using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1b_P2
{
    public partial class TempConversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnconvert_Click(object sender, EventArgs e)
        {
            BLL.Converter converter = new BLL.Converter();
            if ((tbcelcius.Text == "") && (tbfah.Text != ""))
            {
                // Fahrenheit -> Celcius
                try
                {
                    Double dFahrenheit = Convert.ToDouble(tbfah.Text);
                    Double dCelcius = converter.convertToCelcius(dFahrenheit);
                    tbcelcius.Text = dCelcius.ToString();
                }
                catch (FormatException fe)
                {
                    // show alert 
                }

            }
            else if ((tbcelcius.Text != "") && (tbfah.Text == ""))
            {
                // Celcius -> Fahrenheit
                try
                {
                    Double dCelcius = Convert.ToDouble(tbcelcius.Text);
                    Double dFahrenheit = converter.convertToFahrenheit(dCelcius);
                    tbfah.Text = dFahrenheit.ToString();
                }
                catch (FormatException fe)
                {
                    // show alert
                }

            }
            else
            {
                // do nothing

            }
        }
    }
}