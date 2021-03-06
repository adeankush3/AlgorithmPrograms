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
        public void Angram()
        {
            string str1 = "heart";
            string str2 = "earth";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1=new string(ch1);
            string val2=new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both The String Are Angram");
            }
            else
            {
                Console.WriteLine("String Are Not Angram");
            }
        }
        public void PrimeNumber()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }

        public void Bubble()
        {

            int[] Array = { 87, 95, 85, 18, 33, 32, 52, 78, 91, };
            int temp;

            Console.WriteLine("Array Before Sorting: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }

            for (int j = 0; j <= Array.Length - 2; j++)
            {
                for (int i = 0; i <= Array.Length - 2; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        temp = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Array is:");

            foreach (int data in Array)
            {
                Console.Write(data + " ");
            }

        }
        public void InsertionSort()
        {
            string[] stringArray = { "Sunday", "Monday", "Friday", "Thursday", "Wednesday","Tuesday","Saturday" };

            System.Console.WriteLine("Before Sort Array :");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }

            for (int i = 1; i < stringArray.Length; i++)
            {
                string value = stringArray[i];
                int j = i - 1;
                while ((j >= 0) && (stringArray[j].CompareTo(value) > 0))
                {
                    stringArray[j + 1] = stringArray[j];
                    j--;
                }
                stringArray[j + 1] = value;
            }

            System.Console.WriteLine("Afer Sort Array is:");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }
        
        public static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] left = new int[n1];
            int[] right = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
            {
                left[i] = arr[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
        
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine("SortedArray");




        }
    }
}
