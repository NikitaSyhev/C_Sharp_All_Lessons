using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LINQ_Example
{
    internal class Program
    {
        static void analyze(object[] _arr, string _symbol)
        {
            string all_arr = "";
            foreach (var item in _arr)
            {
                if (item.ToString().StartsWith(_symbol))
                {
                    Console.WriteLine($"{item} начинается c {_symbol}");
                }
                if (item.ToString().Contains(_symbol))
                {
                    Console.WriteLine($"{item} содержит символ {_symbol}");
                }
                all_arr += item + " ";
            }
            Console.WriteLine("Проанализирован массив: {0}", all_arr);
        }
        static void orderByDescending(object[] _arr)
        {
            Console.WriteLine("Отсортировано средствами \'OrderByDescending\' по убыванию");
            foreach (var item in _arr.OrderByDescending(p => p)) Console.Write(" " + item);
            Console.WriteLine("\n");
        }
        static void orderByDescending(int[] _arr)
        {
            Console.WriteLine("Отсортировано средствами \'OrderByDescending\' по убыванию");
            foreach (var item in _arr.OrderByDescending(p => p)) Console.Write(" " + item);
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] _arr01 = { 0,2,3,24,5,1,34,467,78,4};
            string start_symbol = "4";
            string all_arr01 = string.Empty;
            string[] _arr02 = { "ds4", "34", "43", "22", "Hello!"};
            foreach (var item in _arr01)
            {
                if (item.ToString().StartsWith(start_symbol))
                {
                    Console.WriteLine($"{item} начинается c {start_symbol}");
                }
                if (item.ToString().Contains(start_symbol))
                {
                    Console.WriteLine($"{item} содержит символ {start_symbol}");
                }
                all_arr01 += item + " ";
            }
            Console.WriteLine("Проанализирован массив: {0}", all_arr01);
            analyze(_arr02, start_symbol);
            orderByDescending(_arr02);
            orderByDescending(_arr01);
            Console.ReadKey();
        }
    }
}
