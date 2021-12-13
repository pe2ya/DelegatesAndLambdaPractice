using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static DU.stat_class;

namespace DU
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operation operation = Add;
               Console.WriteLine(operation(12, 5));
               operation = Sub;
               Console.WriteLine(operation(12, 5));
               operation = Mul;
               Console.WriteLine(operation(12, 5));
               operation = Div;
               Console.WriteLine(operation(12, 5));

               Console.WriteLine("----------------------------");
            */

            Operation[] operations = { Add, Sub, Mul, Div };

            Random rnd = new Random();
            int a = rnd.Next(10);
            int b = rnd.Next(10);

            Console.WriteLine(a + ", " + b);
            Console.WriteLine(" ");

            int i;
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Add, 2 - Subtract, 3 - Multiply, 4 - Divide");
            int choise = 0;
            for (i = 1; i > 0; i++)
            {
                choise = Convert.ToInt32(Console.ReadLine());
                choise--;

                if (choise >= 0 && choise < 4)
                {
                    break;
                }
            }

            Console.WriteLine("Result: " + operations[choise](a, b) + "\n");
            Console.WriteLine("-------------------------");


            Bank an = new Bank("Andrii", 10000, 5000);
            List<Bank> list = new List<Bank>();
            list.Add(an);
            list.Add(new Bank("David", 20000, 100));
            list.Add(new Bank("Max", 5000, 10000));
            list.Add(new Bank("Jack", 30000, 15000));
            list.Add(new Bank("Bob", 25000, 1100));
            
            foreach (var c in list)
            {
                Console.WriteLine(c);
            }

            MyBank customerBank = GetName;
            int x = 5;
            int amount = 0;

            Console.WriteLine("\nEnter the name");
            string name = Console.ReadLine();
            while (x != 0)
            {

                Console.WriteLine("1 - simulation, 2 - add money to bank account, 3 - pay the loan, 4 - pay the loan from bank account, 5 - change name, 0 - quit ");

                x = Convert.ToInt32(Console.ReadLine());
                while (x < 0 && x > 5)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }

                switch (x)
                {
                    case 1:
                        foreach (var ba in list.Simulace())
                        {
                            Console.WriteLine(ba);
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine("\nEnter the amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        foreach (var ba in list.AddMoney(customerBank, name, amount))
                        {
                            Console.WriteLine(ba);
                        }
                        Console.WriteLine(" ");

                        break;
                    case 3:
                        Console.WriteLine("\nEnter the amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        foreach (var ba in list.EditPujcka(customerBank, name, amount))
                        {
                            Console.WriteLine(ba);
                        }
                        Console.WriteLine(" ");

                        break;
                    case 4:
                        foreach (var ba in list.AddMoneyToP(customerBank, name))
                        {
                            Console.WriteLine(ba);
                        }
                        Console.WriteLine(" ");

                        break;
                    case 5:
                        Console.WriteLine("\nEnter new name");
                        name = Console.ReadLine();
                        break;

                }
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine(" ");

            MyFunction<int> Cube = x => x * x * x;

            foreach (int n in numbers)
            {
                Console.Write(Cube(n) + " ");
            }

            Console.WriteLine("\n -------------------------");

            String[] names = { "David", "Andrii", "Pavel", "Jan", "Vojta" };
            foreach (string n in names)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine(" ");

            Function sort = s =>
            {
                var _sort = s.OrderByDescending(x => x.Length).ThenBy(x => x); 
                return _sort;
            };
            /*
             I use this web page https://stackoverflow.com/questions/35727294/lexicographically-sort-c-sharp
             because I didn't really understand what a lexicographical order was
             but now I get it :)
            */

            foreach (string n in sort(names))
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n -------------------------");

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine(" ");

            foreach (var n in Method<int>(numbers, s => s % 2 == 0))
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n -------------------------");


            Console.WriteLine("Whats vectors length must be?");
            int len = 0;
            for (i = 1; i > 0; i++)
            {
                len = Convert.ToInt32(Console.ReadLine());

                if (len > 0)
                {
                    break;
                }
            }

            int[] vector1 = new int[len];
            int[] vector2 = new int[len];

            for (i = 0; i < len; i++)
            {
                int vnumber1 = rnd.Next(100);
                int vnumber2 = rnd.Next(100);

                vector1[i] = vnumber1;
                vector2[i] = vnumber2;
            }

            foreach (int v in vector1)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine(" ");

            foreach (int v in vector2)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine(VectorM(vector1, vector2));




        }

    }
}
