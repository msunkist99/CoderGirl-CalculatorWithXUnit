using System;

namespace CalculatorWithXUnit
{
    public static class Program
    {
        public static void Main()
        {
            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            double result = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            string firstNumberString = "";
            string secondNumberString = "";

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            bool inputValidated = false;

            while (inputValidated == false)
            {
                Console.WriteLine("enter your FIRST number - ");

                try
                {
                    firstNumberString = Console.ReadLine();

                    firstNumber = double.Parse(firstNumberString);
                    inputValidated = true;
                }
                catch (FormatException ex)
                {
                    ArgumentException argumentException = new ArgumentException(firstNumber.ToString(), ex.Message);
                    Console.WriteLine(firstNumberString + " - " + ex.Message);
                    //Console.WriteLine("enter your FIRST number - ");
                }
            }


            inputValidated = false;

            while (inputValidated == false)
            {
                Console.WriteLine("enter your SECOND number - ");

                try
                {
                    secondNumberString = Console.ReadLine();
                    secondNumber = double.Parse(secondNumberString);
                    inputValidated = true;
                }
                catch (FormatException ex)
                {
                    ArgumentException argumentException = new ArgumentException(secondNumber.ToString(), ex.Message);
                    Console.WriteLine(secondNumberString + " - " + ex.Message);
                    //Console.WriteLine("enter your SECOND number - ");
                }
            }

            inputValidated = false;
            while (inputValidated == false)
            {

                Console.WriteLine("add " + firstNumber + " and " + secondNumber);
                Console.WriteLine("subtract " + secondNumber + " from " + firstNumber);
                Console.WriteLine("multiply " + firstNumber + " and " + secondNumber);
                Console.WriteLine("divide " + secondNumber + " by " + firstNumber);
                Console.WriteLine("enter your option for the numbers - ");
                string option = Console.ReadLine();

                if ((option == "add") || (option == "subtract") || (option == "multiply") || (option == "divide"))
                {
                    // Use methods for each type of calculation.
                    if (option == "add")
                    {
                        result = Add(firstNumber, secondNumber);
                    }
                    else if (option == "subtract")
                    {
                        result = Subtract(firstNumber, secondNumber);
                    }
                    else if (option == "multiply")
                    {
                        result = Multiply(firstNumber, secondNumber);
                    }
                    else if (option == "divide")
                    {
                        result = Divide(firstNumber, secondNumber);
                    }

                    Console.WriteLine($"Total = {result}");
                    inputValidated = true;
                }
                else
                {
                    Console.WriteLine(option + " - invalid option entered");

                }
                Console.ReadLine();
            }
        }

        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>sum</returns>
        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        /// <summary>
        /// subtracts second number from first number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>result</returns>
        public static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        /// <summary>
        /// multiplies two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>returns product of two numbers</returns>
        public static double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }

        /// <summary>
        /// divides firstNumber by the second number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>returns quotient</returns>
        public static double Divide(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
}
