﻿using Calculator.models;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var isRunning = true;
                    
            models.Calculator calc = new models.Calculator();

            Console.WriteLine("welcome to our calculator");

            while (isRunning)
            {

            Console.WriteLine("Start your calculation.");
            Console.WriteLine("number 1:");
            string number1Input = Console.ReadLine();
            Console.WriteLine("number 2:");
            string number2Input = Console.ReadLine();
            Console.WriteLine("operation:");
            string operation = Console.ReadLine();

            decimal.TryParse(number1Input, out var number1);
            decimal.TryParse(number2Input, out var number2);

            CalculationType? calculationType = null;

            switch (operation)
            {
                case "+":
                    calculationType = CalculationType.ADDITION;
                    break;

                case "-":
                    calculationType = CalculationType.SUBTRACTION;
                    break;

                case "*":
                    calculationType = CalculationType.MULTIPLICATION;
                    break;

                case "/":
                    calculationType = CalculationType.DIVISTION;
                    break;
            }

            if (calculationType.HasValue)
                Console.WriteLine(calc.Calculate(number1, number2, calculationType.Value));

                Console.WriteLine("Do you want to continue? y/n");
                string choice = Console.ReadLine();

                if (choice.ToLower().Equals("n"))
                {
                    isRunning = false;
                }
            }
        }
    }
}
