using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Classes
{
    internal class CalculateArea
    {
        public static string GetArea(int length, int width)
        {
            int area = length * width;
            return area.ToString();

        }
    }
}
