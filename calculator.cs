using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.Write("Enter the first number: ");
                double firstNumber = GetValidNumber();
                Console.Write("Enter the second number: ");
                double secondNumber = GetValidNumber();
                Console.WriteLine("Select operation: (1) Addition (2) Subtraction (3) Multiplication (4) Division");
                Console.Write("Your choice: ");
                int operationChoice = GetValidOperationChoice();
                double result = 0;
                string operation = "";

                switch (operationChoice)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        operation = "+";
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        operation = "-";
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        operation = "*";
                        break;
                    case 4:
                      
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue; 
                        }
                        result = firstNumber / secondNumber;
                        operation = "/";
                        break;
                }

                
                Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {result}");

                
                Console.Write("Do you want to perform another calculation? (Yes/No): ");
                string userResponse = Console.ReadLine().Trim().ToLower();

               
                continueCalculating = (userResponse == "yes");
            }

            Console.WriteLine("Goodbye!");
        }

       
        static double GetValidNumber()
        {
            double number;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    return number; 
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid numeric value: ");
                }
            }
        }

       
        static int GetValidOperationChoice()
        {
            int choice;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
                {
                    return choice; 
                }
                else
                {
                    Console.Write("Invalid choice. Please select a valid operation (1-4): ");
                }
            }
        }
    }
}