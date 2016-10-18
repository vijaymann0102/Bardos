using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class LinkedListElment5
    {
        //Assumes the list is stored in array as strings
        public static string GetFifthElementFromEnd(string[] list)
        {
            try
            {
                int lengthOfList = list.Length;

                if (lengthOfList > 4)
                {
                    return list[lengthOfList - 5];
                }
            }
            catch(Exception ex)
            {

            }
            return "";
        }

        //Assumes the list is stored in list int collection  
        public static string GetFifthElementFromEnd(List<int> list)
        {
            if(list.Count>4)
            {
                return Convert.ToString(list.ElementAt(list.Count - 5));
            }

            return "";
        }
    }
}
