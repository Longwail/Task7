using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7_1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                if (str.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");

                int lastColonIndex = -1;
                for (int i = str.Length - 1; lastColonIndex < 0 ? i >= 0 : i < str.Length - 1;)
                {
                    if (str[i] == ':')
                    {
                        lastColonIndex = i;
                    }
                    if (lastColonIndex > 0)
                    {
                        i++;
                        Console.Write(str[i]);
                    }
                    else
                        i--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
