using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1.Models
{
    public class Temperature
    {
        public static string Fever( int temperature)
        {
            if(temperature > 38)
            {
                return "Check with a doctor!";
            }
            else
            {
                return " temperature is normal :D";
            }
        }
    }
}
