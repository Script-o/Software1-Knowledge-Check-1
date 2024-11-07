using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator_Net8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            string mathText = "";
            string symbolText = "";

            int[] numbers = new int[3];
            numbers[0] = 0;

            switch (input)
            {
                case "1":
                    mathText = "add";
                    symbolText = "+";
                    break;
                case "2":
                    mathText = "subtract";
                    symbolText = "-";
                    break;
                case "3":
                    mathText = "multiply";
                    symbolText = "*";
                    break;
                case "4":
                    mathText = "divide";
                    symbolText = "/";
                    break;
                default:
                    break;
            }

            if (input == "1" || input == "2" || input == "3" || input == "4")
            {
                Console.WriteLine($"Enter 2 integers to {mathText}");
                var number1 = Console.ReadLine() ?? "FAIL";
                var number2 = Console.ReadLine() ?? "FAIL";

                numbers = InputCheck.IntegerCheck(number1, number2);
            }

            //Checks if the IntegerCheck passed 1 "true" or 0 "false" 
            if (numbers[0] == 1)
            {
                Console.Write($"{numbers[1]} {symbolText} {numbers[2]} = ");
                switch (input)
                {
                    case "1":
                        Console.Write(calculator.Add(numbers[1], numbers[2]));
                        break;
                    case "2":
                        Console.Write(calculator.Subtract(numbers[1], numbers[2]));
                        break;
                    case "3":
                        Console.Write(calculator.Multiply(numbers[1], numbers[2]));
                        break;
                    case "4":
                        Console.Write(calculator.Divide(numbers[1], numbers[2]));
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unknown input");
            }
        }
    }
}