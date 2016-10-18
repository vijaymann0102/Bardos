using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLogic.ReverseString;
using static BusinessLogic.LinkedListElment5;
using static BusinessLogic.TraiangleType;


namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            while (loop)
            {
                Console.WriteLine("Choose the appropriate options to peform the required operation.");
                Console.WriteLine("1 : Reverse the words in the sentence.");
                Console.WriteLine("2 : Get the last 5 element from the List of values inserted in list.");
                Console.WriteLine("3 : Give the type of triangle based on it's side length.");

                var options = Console.ReadLine();

                switch (options)
                {
                    case "1":
                        Console.WriteLine("Input the string to be reveresed.");
                        var inputtedString = Console.ReadLine();
                        Console.WriteLine("Reveresed String : " + GetReversedString(inputtedString));
                        break;

                    case "2":
                        Console.WriteLine("Enter No of elements to be inserted into array");
                        var elementsCount = Console.ReadLine();
                        int counter = 0;
                        int.TryParse(elementsCount, out counter);
                        string[] array = new string[counter];
                        for (int i = 0; i <= counter - 1; i++)
                        {
                            array[i] = Console.ReadLine();
                        }

                        Console.WriteLine("The array 5 th element from end is : " + GetFifthElementFromEnd(array));

                        break;

                    case "3":
                        Console.WriteLine("Input all the three sides of triangle.");
                        List<int> sides = new List<int>(3);
                        try
                        {
                            for (int i = 0; i <= 2; i++)
                            {
                               var localVar = Console.ReadLine();
                               sides.Add(int.Parse(localVar));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Invalid value received for side of Traiangel...Exsiting." + ex.Message);
                            
                        }
                        finally
                        { 
                        if(sides.Count>2)
                          Console.WriteLine("The triangle is :" + GetTriangleType(sides[0], sides[1], sides[2]));
                        }
                        break;
                    default:
                        Console.WriteLine("Please choose one of the option specified only.");
                        break;

                }
                Console.WriteLine("Press A key to Exit/Any other to continue");
                var input=Console.ReadLine();
                if (input == "A")
                    break;
            }
        }
    }
}
