using System;
using System.Text.RegularExpressions;

namespace Supermercado
{
    class Supermercado
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string cad = Console.ReadLine()!;

                if (string.IsNullOrEmpty(cad))
                {
                    break;
                }
                else
                {
                    string regex = Regex.Replace(cad, @"\s+", " ").TrimStart();
                    string[] nums = regex.Split(' ');
                    int[] ints = Array.ConvertAll(nums, s => int.Parse(s));
                    Console.WriteLine(ints.Sum());
                }
            }
        }
    }
}
