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
            BinarySearch b = new BinarySearch();
            b.Bubble();

            
            Console.WriteLine("Welcome to Algorithm Programs :  \n Choose operation :" +
            "\n 1. Binary search" +
            "\n 2. Angram" +
            "\n 3. PrimeNumber" +
            "\n 4. Bubble Sort" +
            "\n 3. Exit");

            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    BinarySearch binarySearch = new BinarySearch();
                    Console.WriteLine("Enter string value to search:");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("User input is :" + userInput);
                    binarySearch.BinarySearchIterative(userInput);
                    break;
                case 2:
                    BinarySearch binarySearch1 = new BinarySearch();
                    binarySearch1.Angram();
                    break;
                case 3:
                    BinarySearch binSearch2 = new BinarySearch();
                    binSearch2.PrimeNumber();
                    break;
               // case 4:
                //    BinarySearch binSearch3 = new BinarySearch();
                 //   binSearch3.Bubble();
                default:
                    Console.WriteLine("Choose correct option");
                    break;
            }
        }
    }
}
