using KnowledgeCheck1_Calculator_Net8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator_Net8
{
    public class InputCheck
    {
        public static int[] IntegerCheck(string input, string input2)
        {
           int[] numbers = new int[3];

            if (int.TryParse(input, out int addNumOne) && int.TryParse(input2, out int addNumTwo))
            {
                //Sets the first number to a "true" statement
                numbers[0] = 1;
                numbers[1] = addNumOne;
                numbers[2] = addNumTwo;
                return numbers;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                //Sets the first number to a "false" statement
                numbers[0] = 0;
                return numbers;
            }
        }
    }
}