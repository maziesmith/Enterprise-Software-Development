using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practical_7.Services
{
    /// <summary>
    /// Summary description for TemperatureConverter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureConverter : System.Web.Services.WebService
    {

        [WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        public double ToCelsius(double temperature)
        {
            return Math.Round(9 / 5 * (temperature - 32), 1);
        }
        [WebMethod]
        public double ToFahrenheit(double temperature)
        {
            return Math.Round(9 / 5 * temperature + 32, 1);
        }
    }
}
