using System;
using System.Collections.Generic;
using TaskGeneric.Models;

namespace TaskGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor
             = ConsoleColor.Green;
            Person intList = new Person();
            Person intList1 = new Person();
            intList.Id = 345;
            intList1.Id = 123;
            intList.Show();
            intList1.Show();
            Student stringList = new Student();
            Student stringList1 = new Student();
            stringList.Name ="Anar";
            stringList1.Name = "Atar";
            stringList.Show();
            stringList1.Show();
            Console.WriteLine("----------------------");
            Console.BackgroundColor
             = ConsoleColor.Blue; 

            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(50);
            numbers.Add(56);
            numbers.Add(7);
            numbers.Add(500);    
            numbers.Add(4008);
            numbers.Add(8);
            numbers.Add(58);
            numbers.LastIndexOf(2);
            numbers.Remove(50);
            numbers.Exists(numbers => numbers == 500);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //numbers.Clear();
            Console.WriteLine(numbers[4]);
            Console.WriteLine($"Count: {numbers.Count}");
            Console.BackgroundColor
             = ConsoleColor.Black;

        }
    }
}
