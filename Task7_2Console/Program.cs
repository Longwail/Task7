using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите строку: ");
                string data = Console.ReadLine();
                if (data.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");
                var result = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .GroupBy(x => x)
                    .Where(x => x.Count() == 1)
                    .Select(x => x.Key);
                foreach (var item in result) Console.Write(item + " ");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
