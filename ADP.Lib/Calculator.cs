using ADP.Model.Entity;
using System.Numerics;

namespace ADP.Lib
{
    public static class Calculator
    {
        public static decimal Addition(ADPTask model)
        {
            return model.Left + model.Right;
        }

        public static decimal Subtraction(ADPTask model)
        {
            return model.Left - model.Right;
        }

        public static BigInteger Multiplication(ADPTask model)
        {
            return (BigInteger)model.Left * (BigInteger)model.Right;
        }

        public static decimal Division(ADPTask model)
        {
            return (decimal)model.Left / (decimal)model.Right;
        }

        public static decimal Remainder(ADPTask model)
        {
            return model.Left % model.Right;
        }
    }
}
