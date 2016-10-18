using NUnit.Framework;
using static BusinessLogic.ReverseString;
using static BusinessLogic.LinkedListElment5;
using static BusinessLogic.TraiangleType;

namespace TestCases
{
    [TestFixture]
    public class BarnardosTests
    {

        [TestCase("Lets see", ExpectedResult  = "ees steL")]
        [TestCase("Lets see 1", ExpectedResult = "stel ees 1")]
        [TestCase("Lets see 1", ExpectedResult = "steL ees 1")]
        [TestCase("123 2", ExpectedResult  = "321 2")]
        [TestCase("Should fail mate", ExpectedResult = "yeah")]
        public string CheckReverse(string toTest)
        {
            return GetReversedString(toTest); 
        }

        [TestCase("1,2,3,4,5,6,7,8,9",ExpectedResult ="5")]
        [TestCase("1,2,3,4,2,6,7,8,9", ExpectedResult = "2")]
        [TestCase("1,2,3,4,2,6,7,8,9", ExpectedResult = "222")]
        [TestCase("1", ExpectedResult = "222")]
        public string Check5thElement(string array)
        {
            return GetFifthElementFromEnd(array.Split(','));
        }

        [TestCase(1,2,1,ExpectedResult = "Isosceles")]
        [TestCase(1, 1, 1, ExpectedResult = "Equilateral")]
        [TestCase(1, 2, 3, ExpectedResult = "Scalene")]
        [TestCase(1, 2, 3, ExpectedResult = "Equilateral")]
        public string CheckTriangleType(int sideA,int sideB,int sideC)
        {
          return GetTriangleType(sideA, sideB, sideC);
        }

    }


}