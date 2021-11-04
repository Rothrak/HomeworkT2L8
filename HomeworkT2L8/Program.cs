using System;

namespace HomeworkT2L8
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("Wybierz program który chcesz uruchomić:");
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Program1();
                    break;
                case 2:
                    Program2();
                    break;
                case 3:
                    Program3();
                    break;
                case 4:
                    Program4();
                    break;
                case 5:
                    Program5();
                    break;
                case 6:
                    Program6();
                    break;
                case 7:
                    Program7();
                    break;
                case 8:
                    Program8();
                    break;
                case 9:
                    Program9();
                    break;
                case 10:
                    Program10();
                    break;
                default:
                    Console.WriteLine("Wybrałeś zły program");
                    break;
            }
            Console.ReadKey();
        }

        public static void Program1()
        {
            int a = 0;
            
            int razy = 0;

            for (int i = 2; i < 101; i++)
            {
                a = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            a = 1;
                            break;
                        }
                    }
                    if (a == 0)
                    {
                        razy++;
                    }
                }
            }
           
            Console.WriteLine($"W tym przedziale jest {razy} liczb pierwszych");
        }

        public static void Program2()
        {
            int b = 0;
            int razy = 0;
            do
            {
                if (b % 2 == 0)
                {
                    razy++;
                }
                b++;  
            }
            while (b < 1001);
            Console.WriteLine($"W tym przedziale jest {razy} liczb parzystych");

        }
        public static void Program3()
        {
            int a1 = 0;
            int a2 = 1;
            int suma;

            Console.WriteLine("Jak długi ma być ciąg Fibbonaciego:");
            int n = int.Parse(Console.ReadLine());

            Console.Write(a1 + " ");
            Console.Write(a2 + " dalszy ciag: \r\n");

            for (int i = 0;i<n;i++)
            {
                suma = a1 + a2;

                a1 = a2;
                a2= suma;

                Console.WriteLine($"{suma}");
            }
        }
        public static void Program4()
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            int rows = 0;

            if (n == 1)
            {
                rows = 1;
            }
            else if (n > 1 && n <= 3)
            {
                rows = 2;
            }

            else if (n > 3 && n <= 6)
            {
                rows = 3;
            }
            else if (n > 3 && n <= 10)
            {
                rows = 4;
            }
            else if (n > 11 && n <= 15)
            {
                rows = 5;
            }
            else if (n > 15 && n <= 21)
            {
                rows = 6;
            }
            else
            {
                rows = n;
            }

            for (int a = 1; a <= rows; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write($" {c}" );
                    c++;
                }
                Console.Write("\r\n");
            }
            }
        public static void Program5()
        {
            for(int i=1;i<21;i++)
            {
                Console.WriteLine($"Potęga {i} to {Math.Pow(i, 3)}");
                
            }
        }
        public static void Program6()
        {
            float a = 1;
            float suma = 0;
            float all = 0;

            Console.WriteLine("Obliczenie sumy wg wzoru a + a/2 + a/3 + a/4 itd.: ");

            for (float i=1;i <21;i++)
            {
                suma = a / i;
                all = all + suma;
            }
            Console.WriteLine($"Wynik: {all}");
        }
        public static void Program7()
        {
            int x, y, z;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            
            for (x = 5; x >= 1; x--)
            {
                for (y = 6; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 2; z < (x * 2) - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void Program8()
        {
            string my_word;
            string my_word_reverse = string.Empty;

            Console.WriteLine("Wprowadz lancuch znakow: ");
            my_word = Console.ReadLine();

            Console.WriteLine("Wprowadzone słowo: " + my_word);

            for (int i = my_word.Length - 1; i >= 0; i--)
            {
                my_word_reverse = my_word_reverse + my_word[i];
            }
            Console.Write($"Wpisany lancuch znakow od tylu : {my_word_reverse} ");
            Console.ReadLine();

        }
        public static void Program9()
        {
            Console.WriteLine("Podaj liczbę w sytemie dziesiętnym");
            int a = int.Parse(Console.ReadLine());

            string d = "";
            while (a > 0)
            {
                d = d + (a % 2);
                a = a / 2;

            }
            string bin = string.Empty;
            for (int i = d.Length - 1; i >= 0; i--)
            {
                bin = bin + d[i];
            }

            Console.WriteLine(bin);
        }
        public static void Program10()
        {
            Console.WriteLine("Podaj pierwsza liczbę ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ");
            int y = int.Parse(Console.ReadLine());

            int mul = x * y;

            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            Console.WriteLine("Najmniejsza wspolna wielokrotnosc: (NWD) to: " + mul / x);
        }
    }
}
