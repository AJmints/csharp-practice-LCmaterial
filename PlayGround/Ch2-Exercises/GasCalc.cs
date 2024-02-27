using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Classes
{
    internal class GasCalc
    {
        public static string GetMilage(int milesDriven, int gallonsUsed)
        {
            int mpg = milesDriven / gallonsUsed;
            return mpg.ToString();
        }
    }
}
