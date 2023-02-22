//Supermercado con regex C Sharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Supermercado
{
    class Supermercado
    {
        static void Main(string[] args)
        {
            //def
            string cad, regex;
            int conta = 0;

            while (true)
            {
                cad = Console.ReadLine()!;

                if (string.IsNullOrEmpty(cad))
                {
                    Environment.Exit(0);
                }
                else
                {
                    //cadenas.Add(cad);
                    regex = Regex.Replace(cad, @"\s+", " ").TrimStart();
                    string[] nums = regex.Split(' ');

                    conta = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        conta = conta + int.Parse(nums[j]);
                    }
                    Console.WriteLine(conta);
                }
            }
        }
    }
}