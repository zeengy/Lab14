using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] ReadFromFile(string filename)
            {
                try
                {
                    return File.ReadAllLines(filename);
                }
                catch (Exception ex)
                {
                    return new string[0];
                }
            }

            void PrintArray(string[] array)
            {
                foreach (string item in array)
                {
                    Console.WriteLine(item);
                }
            }

     
            void WriteToFile(string[] data, string filename)
            {
                    File.WriteAllLines(filename, data);
                    Console.WriteLine("Done to: " + filename);
            }

            void SortArray(string[] array)
            {
                Array.Sort(array);
            }

            void FindByCriterion(string[] array, string criterion)
            {
                foreach (string item in array)
                {
                    if (item.Contains(criterion))
                    {
                        Console.WriteLine(item);
                    }
                }
            }


            string[] arr = ["Hello", "Array", "Integer", "Char", "Hel"];

            SortArray(arr);
            PrintArray(arr);

            string[] datatext = ReadFromFile("input.txt");
            string text = datatext[0];
            Console.WriteLine(text);

            FindByCriterion(arr, "Hel");

            WriteToFile(datatext, "output.txt");

        }
    }
}
