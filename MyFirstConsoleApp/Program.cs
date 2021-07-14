using System;
using System.Collections.Generic;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // string name;
            // input data

            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            // name = "John";
            // const string name = "John";
            Console.WriteLine("Hello World!" + name);

            // 64bit unsigned
            ulong favNumber = 6;


            double accountBalance = 1.57d;
            decimal balance = 1.57M;

            bool isTeaching = true;

            var imaBool = true;

            //datetime is for holding ... datetime

            var today = new DateTime(2021, 7, 13);

            today = DateTime.Today;
            
            Console.WriteLine("Today's date is {0}", today);

            // Dictionary<List<Tuble<string, int>>, string> myStuff = new Dictionary<List<Tuble<string, int>>, string>(); ist>

            // type inference;
            var someStuff = 5 * 5;

            // var students = new string[5];

            //             list of string
            var students = new List<string>();

            students.Add("Nathan");
            students.Add("John");
            students.Add("Hunter");
            students.Remove("Hunter");

            for (var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
            
            foreach(var student in students)
            {
                Console.Write("{0}, ", student);
            }
            Console.Write('\n');

            // if blocks same as javascript, but no triple equals ===

           
        }
    }
}
