using System;

namespace Task3

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Введите четное число >=4");

            int myint = new int();

            while (true)


            {

                var Vvod = (Console.ReadLine());

                if (!int.TryParse(Vvod, out myint) || !(int.Parse(Vvod) >= 4) || !((int.Parse(Vvod)) % 2 == 0))

                {

                    Console.WriteLine("Ошибка ввода\n");

                    continue;

                }

                else

                {

                    for (int i = 1; i <= myint / 2; i++)

                    {

                        if (IsNumberPrime(i) && IsNumberPrime(myint - i))

                        {

                            Console.WriteLine($"{i} + {myint - i}");

                        }

                    }

                    break;

                }

            }

        }

        static bool IsNumberPrime(int i)

        {

            for (int j = 2; j <= (int)Math.Sqrt(i); j++)

            {

                if (i % j == 0)

                {

                    return false;

                    break;

                }

            }

            return true;

        }

    }

}