using System;
using System.Collections.Generic;
using System.Linq;

namespace Zjazd7
{
    class Program
    {
        public static string RandomString()
        {
            var size = new Random();
            var chars = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomString = new string(
                Enumerable.Repeat(chars, size.Next(5, 10))
                    .Select(x => x[random.Next(x.Length)])
                    .ToArray());

            return randomString;
        }

        public static int[] RandomTab()
        {
            var rnd = new Random();
            var size = 10;
            int[] tab = new int[size];

            for (int i = 0; i < size; i++)
            {
                tab[i] = rnd.Next(0, 100);
            }

            return tab;
        }

        static void Main(string[] args)
        {
            int size = 100;
            MyClass[] TabOfElements = new MyClass[size];
            List<MyClass> ListOfElements = new List<MyClass>();

            for (int i = 0; i < size; i++)
            {
                TabOfElements[i] = new MyClass();
                TabOfElements[i].Id = i + 1;
                TabOfElements[i].Name = RandomString();
                TabOfElements[i].Tab = RandomTab();
                ListOfElements.Add((MyClass) TabOfElements[i].Clone());
            }

            for (int i = 0; i < size; i++)
            {
                TabOfElements[i].Name = "";
                TabOfElements[i].Tab = new[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

                Console.Write("TabOfElements: ");
                TabOfElements[i].Print();
                Console.Write("ListOfElements: ");
                ListOfElements[i].Print();
            }

            Console.WriteLine();

            ListOfElements.Sort();
            foreach (var listOfElement in ListOfElements)
            {
                listOfElement.Print();
            }
        }
    }
}