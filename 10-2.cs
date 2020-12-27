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

            Console.WriteLine();
            MultiplyByColumn(FirstArray);

            static void MultiplyByColumn(int[,] inputArray)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    int multiplication = 1;
                    for (int i = 0; i < inputArray.GetLength(0); i += 2)
                    {
                        multiplication *= inputArray[i, j];
                    }
                    Console.WriteLine($"{j} - {multiplication} ");
                }
            }


        }
    }
}
