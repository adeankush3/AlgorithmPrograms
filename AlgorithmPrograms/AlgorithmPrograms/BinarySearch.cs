using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void BinarySearchIterative(string userInput)
        {
            string[] strInputArray = { "Ankush", "Hariprasad", "Jayshree", "Ramrao", "Ade" };
            int minimum = 0, middle = 0, result = -1;
            int maximum = strInputArray.Length - 1;

            Console.Write("Array values is:-");
            for (int i = 0; i <= maximum; i++)
            {
                Console.WriteLine(strInputArray[i]);
            }
            Console.WriteLine("\n");

            
            while (minimum <= maximum)
            {
                middle = minimum + (minimum - 1) / 2;

                if (userInput.Equals(strInputArray[middle]))
                {
                    result = 0;
                }

                if (result == 0)
                {
                    Console.WriteLine("Matching");
                }

                int val = Convert.ToInt32(userInput.CompareTo(strInputArray[middle]));

                if (val == 1)
                {
                    minimum = middle + 1;
                    result = 1;
                }
                else
                {
                    maximum = middle - 1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine("String not found");
            }
            else if (result == 1)
            {
                Console.WriteLine("String is found");
            }

        }
    }
}
