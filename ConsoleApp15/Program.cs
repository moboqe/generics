using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    public class Mnozhestvo<T>
    {
        protected T[] Values = new T[10];
        protected int index = 0;
        public void Add(T value)
        {
            Values[index] = value;
            index++;
        }
        public void Add_elem(T value)
        {
            if (index < 10)
            {
                Values[index] = value;
                index++;
            }
            else Console.WriteLine("Множество заполнено");
        }
        public void ShowValues()
        {
            for (int i = 0; i < index; i++)
                Console.Write(Values[i] + "  ");
        }
        public static Mnozhestvo<T> operator +(Mnozhestvo<T> a1, Mnozhestvo<T> a2)
        {
            Mnozhestvo<T> arr1 = new Mnozhestvo<T>();
            return arr1;
        }
        public static Mnozhestvo<T> operator *(Mnozhestvo<T> a1, Mnozhestvo<T> a2)
        {
            Mnozhestvo<T> arr1 = new Mnozhestvo<T>();
            return arr1;
        }
        public static Mnozhestvo<T> operator -(Mnozhestvo<T> a1, Mnozhestvo<T> a2)
        {
            Mnozhestvo<T> arr1 = new Mnozhestvo<T>();
            return arr1;
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
            range = rnd.Next(5, 10);
            int x = range;
            for (int i = 0; i < range; i++)
            {
                arr1.Add(rnd.Next(-10, 11));
            }
            range = rnd.Next(5, 10);
            for (int i = 0; i < range; i++)
            {
                arr2.Add(rnd.Next(-10, 11));
            }
            range = rnd.Next(5, 10);
            int y = range;
            for (int i = 0; i < range; i++)
            {
                arr3.Add(Convert.ToDouble(rnd.Next(-10, 11) / 10d));
            }
            range = rnd.Next(5, 10);
            for (int i = 0; i < range; i++)
            {
                arr4.Add(Convert.ToDouble(rnd.Next(-10, 11) / 10d));
            }
            Console.Write("Целочисленный массив " + x + "\n");
            arr1.ShowValues();
            Console.WriteLine();
            Console.Write("Вещественный массив " + y + "\n");
            arr3.ShowValues();


            Console.ReadKey();
        }
    }
}
