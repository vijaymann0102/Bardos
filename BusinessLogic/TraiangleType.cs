using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public static class TraiangleType
   {
        //Gets the input for three sides of triangle and returns the type based on that.
        public static string GetTriangleType(int sideA,int sideB,int sideC)
        {
            if(sideA==sideB && sideB==sideC)
            {
                return "Equilateral";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                return "Isosceles";
            }
            else if(sideA!=sideB && sideB != sideC && sideA!=sideC)
            {
                return "Scalene";
            }
           
            return "Error";
       }
   }
}
