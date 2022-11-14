using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = str1.ToLower();
            string str3 = str2.Replace(" ", "");
            string str4 = "";
            foreach (char c in str3)
            {
                str4 = c + str4;
            }
            if (str4 == str3)
            {
                Console.WriteLine("Фраза является палиндромом");
            }
            else
            {
                Console.WriteLine("Фраза не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}