using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DU
{
    static class stat_class
    {
        public delegate int Operation(int a, int b);
        public delegate int MyFunction<T>(int x);
        public delegate bool MyFunction1<T>(T prvek);
        public delegate bool MyBank(Bank b, string s);
        public delegate IEnumerable<string> Function(IEnumerable<string> x);


        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return (int)(a / b);
        }

        public static bool GetName (Bank b, string name)
        {
            return b.Name == name;
        }

        public static IEnumerable<T> Method<T>(IEnumerable<T> collection, MyFunction1<T> exep)
        {
            foreach (var c in collection)
            {
                if (exep(c))
                {
                    yield return c;
                }
            }

        }
        public static int VectorM (int[] collection1, int[] collection2)
        {
            int result = 0;
            if (collection1.Length == collection2.Length)
            {
                for (int i = 0; i < collection1.Length; i++)
                {
                    result += collection1[i] * collection2[i];
                }
            }
            return result;

        }
        public static IEnumerable<Bank> AddMoney(this IEnumerable<Bank> collection, MyBank exep, string name,int price)
        {
            foreach (var c in collection)
            {
                if (exep(c, name))
                {
                    c.Money += price;
                    yield return c;
                }
            }

        }

        public static IEnumerable<Bank> Simulace(this IEnumerable<Bank> collection)
        {
            foreach (var c in collection)
            {
                    c.Pujcka += c.Pujcka * 0.1;
                    yield return c;
            }
        }

        public static IEnumerable<Bank> EditPujcka(this IEnumerable<Bank> collection, MyBank exep, string name, int price)
        {
            foreach (var c in collection)
            {

                if (exep(c, name))
                {
                    if (c.Pujcka < price)
                    {
                        c.Money += (int)(price - c.Pujcka);
                        c.Pujcka = 0;
                    }
                    else
                    {
                        c.Pujcka -= price;
                    }
                    yield return c;
                }
            }

        }

        public static IEnumerable<Bank> AddMoneyToP(this IEnumerable<Bank> collection, MyBank exep, string name)
        {
            foreach (var c in collection)
            {
                if (exep(c, name))
                {
                    if (c.Pujcka > c.Money)
                    {
                        c.Pujcka -= c.Money;
                        c.Money = 0;
                    }
                    else
                    {
                        c.Money -= (int)(c.Pujcka);
                        c.Pujcka = 0;
                    }
                    yield return c;
                }
            }

        }


        



    }
}
