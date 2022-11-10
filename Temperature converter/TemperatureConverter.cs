using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_converter
{
    public static class TemperatureConverter
    {
        private const double _toCelciusScalar = 1.8;
        public static double ConvertToFarenheit(this double value) =>  value * _toCelciusScalar + 32;
    }
}
