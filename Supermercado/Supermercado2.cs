//Supermercado con Logica C Sharp
using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                string entrada = Console.ReadLine()!;
                if (string.IsNullOrEmpty(entrada))
                {
                    break;
                }
                else
                {
                    char es = ' ';
                    char tab = '\t';
                    int sum = 0;
                    string local = string.Empty;

                    for (int j = 0; j < entrada.Length; j++)
                    {
                        if (entrada[j] != es && entrada[j] != tab)
                        {
                            local += entrada[j];
                            if (j == entrada.Length - 1)
                            {
                                sum += int.Parse(local);
                            }
                        }
                        else
                        {
                            if (local != "")
                            {
                                sum += int.Parse(local);
                                local = string.Empty;
                            }
                        }
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}