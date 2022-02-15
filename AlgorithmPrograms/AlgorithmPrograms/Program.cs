using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Program");

            BinarySearch binarySearch = new BinarySearch();
            Console.WriteLine("Enter string value to search:");
            string userInput = Console.ReadLine();
            Console.WriteLine("User input is :" + userInput);
            binarySearch.BinarySearchIterative(userInput);
        }
    }
}
