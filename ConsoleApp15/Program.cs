﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace ConsoleApp15
{
    public class Mnozhestvo<T> where T : IComparable<T>
    {
        private List<T> mnozh;
        public Mnozhestvo()
        {
            mnozh = new List<T>();
        }
        public Mnozhestvo(params T[] args) : this()
        {
            mnozh.AddRange(args);
        }
        public Mnozhestvo(IEnumerable<T> mas) : this()
        {
            mnozh.AddRange(mas);
        }

        public void Add(T elem)
        {
            mnozh.Add(elem);
        }
        public void Show()
        {
            for(int i=0;i<mnozh.Count;i++)
            {
                Console.Write(this.mnozh.ElementAt(i)+" ");
            }
            Console.WriteLine();
        }
        public void Delete(T elem)
        {
            mnozh.Remove(elem);
        }
        public Mnozhestvo<T> Intersect(Mnozhestvo<T> s) 
        {
            if (this.mnozh.Intersect(s.mnozh).Count()==0)
            Console.WriteLine("Нет одинаковых элементов");
            return new Mnozhestvo<T>(mnozh.Intersect(s.mnozh));
        }
        public Mnozhestvo<T> Union(Mnozhestvo<T> s)
        {
            return new Mnozhestvo<T>(mnozh.Union(s.mnozh));
        }
        public Mnozhestvo<T> Except(Mnozhestvo<T> s)
        {
            return new Mnozhestvo<T>(mnozh.Except(s.mnozh));
        }
        public void Sort()
        {
            this.mnozh.Sort();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int range;
            Mnozhestvo<int> arr1 = new Mnozhestvo<int>();
            Mnozhestvo<int> arr2 = new Mnozhestvo<int>();
            Mnozhestvo<double> arr3 = new Mnozhestvo<double>();
            Mnozhestvo<double> arr4 = new Mnozhestvo<double>();
            Mnozhestvo<string> arr5 = new Mnozhestvo<string>();
            Mnozhestvo<string> arr6 = new Mnozhestvo<string>();

            string letters = "abcdefghijklmnopqrstuvwxyz";

            range = rnd.Next(5, 10);       // длина первого множества
            for (int i = 0; i < range; i++)
            {
                arr1.Add(rnd.Next(-10, 11));
            } 

            range = rnd.Next(5, 10);       // длина второго множества
            for (int i = 0; i < range; i++)
            {
                arr2.Add(rnd.Next(-10, 11));
            }

            range = rnd.Next(5, 10);       // длина третьего множества 
            for (int i = 0; i < range; i++)
            {
                arr3.Add(Convert.ToDouble(rnd.Next(-10, 11) / 10d));
            }

            range = rnd.Next(5, 10);       // длина четвертого множества
            for (int i = 0; i < range; i++)
            {
                arr4.Add(Convert.ToDouble(rnd.Next(-10, 11) / 10d));
            }
           
            range = rnd.Next(5, 10);       // длина пятого множества
            for (int i = 0; i < range; i++)
            {
                arr5.Add(Convert.ToString(letters[rnd.Next(0, letters.Length)]));
            }

            range = rnd.Next(5, 10);       // длина шестого множества
            for (int i = 0; i < range; i++)
            {
                arr6.Add(Convert.ToString(letters[rnd.Next(0, letters.Length)]));
            }

            Console.Write("Целочисленные множества \n");
            Console.WriteLine("Множество 1: "); arr1.Show();
            Console.WriteLine("Множество 2: "); arr2.Show();

            Console.Write("Вещественные множества \n");
            Console.WriteLine("Множество 3: "); arr3.Show();
            Console.WriteLine("Множество 4: "); arr4.Show();

            Console.Write("Строковые множества \n");
            Console.WriteLine("Множество 5: "); arr5.Show();
            Console.WriteLine("Множество 6: "); arr6.Show();

            Console.WriteLine("Пересечение целочисленных множеств 1 и 2: "); arr1.Intersect(arr2).Show();
            Console.WriteLine("Объединение целочисленных множеств 1 и 2: "); arr1.Union(arr2).Show();
            Console.WriteLine("Разность целочисленных множеств 1 и 2: "); arr1.Except(arr2).Show();

            Console.WriteLine("Пересечение вещественных множеств 3 и 4: "); arr3.Intersect(arr4).Show();
            Console.WriteLine("Объединение вещественных множеств 3 и 4: "); arr3.Union(arr4).Show();
            Console.WriteLine("Разность вещественных множеств 3 и 4: "); arr3.Except(arr4).Show();

            Console.WriteLine("Пересечение cтроковых множеств 5 и 6: "); arr5.Intersect(arr6).Show();
            Console.WriteLine("Объединение cтроковых множеств 5 и 6: "); arr5.Union(arr6).Show();
            Console.WriteLine("Разность cтроковых множеств 5 и 6: "); arr5.Except(arr6).Show();

            Console.ReadKey();
        }
    }
}
