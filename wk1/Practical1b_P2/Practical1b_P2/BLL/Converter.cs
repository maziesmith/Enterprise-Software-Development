using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical1b_P2.BLL
{
    public class Converter
    {
        // Constructor logic

        public Converter()
        {

        }

        public double convertToCelcius(double dFahrenheit)
        {
            double dResult = 0.0f;
            dResult = (dFahrenheit - 32) / 1.8;
            return dResult;
        }

        public double convertToFahrenheit(double dCelcius)
        {
            double dResult = 0.0f;
            dResult = (dCelcius * 1.8) + 32;
            return dResult;
        }
    }
}
