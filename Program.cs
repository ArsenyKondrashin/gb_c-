﻿using System;

namespace sem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строки");
            string value = "";
            string[] array = new string[len];
            for (int i = 0; i < len; i++)
            {
                value = Console.ReadLine();
                array[i] = value;
            }
            Console.WriteLine("Начальный массив:");
            foreach (string i in array) Console.Write("{0} ", i);
            Console.WriteLine("\nОтсортированный массив:");

            foreach (string i in array)
            {
                int length = i.Length;
                if (length <= 3)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}