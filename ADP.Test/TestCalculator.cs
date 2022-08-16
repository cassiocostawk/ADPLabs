using ADP.Lib;
using ADP.Model.Entity;
using System.Numerics;

namespace test.ADPLabs
{
    public class TestCalculator
    {
        [Fact]
        public void CalculeAddition()
        {
            var task = new ADPTask();
            task.Operation = "addition";
            task.Left = -714712834827047;
            task.Right = -7308201900957195;

            Assert.StrictEqual<decimal>(-8022914735784242M, Calculator.Addition(task));            
        }

        [Fact]
        public void CalculeSubtraction()
        {
            var task = new ADPTask();
            task.Operation = "subtraction";
            task.Left = -1930305614642055;
            task.Right = 5415017224193825;

            Assert.StrictEqual<decimal>(-7345322838835880M, Calculator.Subtraction(task));            
        }

        [Fact]
        public void CalculeMultiplication()
        {
            var task = new ADPTask();
            task.Operation = "multiplication";
            task.Left = -9811403477895;
            task.Right = -1320939570388259;
                                                           
            Assert.StrictEqual<BigInteger>(BigInteger.Parse("12960271094996491508074034805"), Calculator.Multiplication(task));            
        }
        
        [Fact]
        public void CalculeDivision()
        {
            var task = new ADPTask();
            task.Operation = "division";
            task.Left = 2136660858836381;
            task.Right = -3390854324202715;

            Assert.StrictEqual<decimal>(-0.6301246395593151655817737295M, Calculator.Division(task));            
        }


        [Fact]
        public void CalculeRemainder()
        {
            var task = new ADPTask();
            task.Operation = "remainder";
            task.Left = 133867730767689;
            task.Right = -1686841961698587;

            Assert.StrictEqual<decimal>(133867730767689M, Calculator.Remainder(task));
        }
    }
}
