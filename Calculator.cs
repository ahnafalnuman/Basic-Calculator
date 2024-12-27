using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Calculator
    {
        // Properties 
        public double X { get; }
        public double Y { get; }

        // Constractor
        public Calculator(double x, double y)
        {
            this.X = x;
            this.Y = y; 
        }
        // ADD
        public double Add()
        {
            return X + Y;
        }

        // SUB
        public double Subtract()
        {
            return X - Y;
        }

        // MULT
        public double Multiply()
        {
            return X * Y;
        }

        // DIV
        public string Divide()
        {
            try
            {

                if (Y == 0)
                {
                    return "Cannot divide by zero";
                }
                else
                {
                    return (X / Y).ToString();
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }

        //Method display all result 
        public string GetResults()
        {
            return $"Sum ({X} + {Y}): {Add()}\n" +
                   $"Difference ( {X} - {Y}): {Subtract()}\n" +
                   $"Product ({X} * {Y}): {Multiply()}\n" +
                   $"Quotient ({X} / {Y}): {Divide()}";
        }
    }
}
