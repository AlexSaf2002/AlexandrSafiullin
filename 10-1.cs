using System;

namespace task10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            int b = int.Parse(Console.ReadLine());

            int[,] FirstArray = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine($"Введите элемент {i} {j}");
                    FirstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{FirstArray[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите делитель к");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(IfDivides(FirstArray, k));

        }

        static string IfDivides(int[,] inputArray, int divider)
        {
            int locationj = new int();
            int locationi = new int();
            bool flag = false;
            for (int j = 0; j < inputArray.GetLength(0); j++)
            {
                for (int i = 0; i < inputArray.GetLength(1); i++)
                {
                    if (inputArray[j, i] % divider == 0)
                    {
                        locationj = j;
                        locationi = i;
                        flag = true;
                        break;
                    }
                }

            }
            if (flag == true)
            {
                return $"В массиве есть элемент, который делится на {divider}, это число {inputArray[locationj, locationi]} с индексами {locationj};{locationi}";
            }
            else
            {
                return $"В массиве нет чисел, которые нацело делятся на {divider}";
            }
        }
    }
}