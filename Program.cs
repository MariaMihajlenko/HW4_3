//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите  число:  ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        char[] arr = numbers.ToString().ToCharArray();
        int i = 0;
        int n = arr.Length;
        Console.Write("[");
        for (i = 0; i < n; i++)
        {

            Console.Write(arr[i] + ",");

        }
        Console.Write("]");
    }
}