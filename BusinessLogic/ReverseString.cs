using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class ReverseString
    {
        //The funciton performs the tasks of reversing a string based on the input string provided.
        public static string GetReversedString(string stringToReverese)
        {
            string reverestedString = string.Empty;
            try
            {
                int lengthString = stringToReverese.Length;
                string[] wordsInString = stringToReverese.Split(' ');
                
                for (int j = 0; j <= wordsInString.Length - 1; j++)
                {
                    for (int i = wordsInString[j].Length - 1; i >= 0; i--)
                    {
                        reverestedString += wordsInString[j][i];
                    }

                    if (wordsInString.Length - 1 != j)
                        reverestedString += " ";
                }
            }
            catch(Exception ex)
            {

            }
            return reverestedString.TrimEnd();
        }
    }
}
