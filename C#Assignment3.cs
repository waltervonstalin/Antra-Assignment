using ConsoleApp2;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Pipelines;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Encodings;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    public class Class
    {
    /* Let’s make a program that uses methods to accomplish a task.Let’s take an array and
       reverse the contents of it.For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
       become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
       To accomplish this, you’ll create three methods: one to create the array, one to reverse the
       array, and one to print the array at the end.
       Your Mainmethod will look something like this:
       static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }
        The GenerateNumbersmethod should return an array of 10 numbers. (For bonus points,
        change the method to allow the desired length to be passed in, instead of just always
        being 10.)
       The PrintNumbersmethod should use a for or foreachloop to print out each item in the
       array.The Reversemethod will be the hardest.Give it a try and see what you can make
       happen.If you get
       stuck, here’s a couple of hints:
       Hint #1:To swap two values, you will need to place the value of one variable in a temporary
       location to make the swap:
       // Swapping a and b.
       int a = 3;
        int b = 5;
        int temp = a;
        a = b;
       b = temp;
       Hint #2:Getting the right indices to swap can be a challenge. Use a forloop, starting at 0
       and going up to the length of the array / 2. The number you use in the forloop will be the
       index of the first number to swap, and the other one will be the length of the array minus
       the index minus 1. This is to account for the fact that the array is 0-based.So basically,
       you’ll be swapping array[index]with array[arrayLength – index – 1].
     */
        public static int[] generatenumbers()
        {
            //int[] result = new int[9];
            Console.WriteLine("Enter the number");
            string input = Console.ReadLine();
            int[] result; 
            result = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); ;
            Console.WriteLine("The Origine Array: ");
            for (int j = 0; j < result.Length; j++)
            {
                Console.Write(result[j] + " ");
            }
            Console.WriteLine();
            return result;
        }
        public static void print(int[] num)
        {
            Console.WriteLine("The Reversed array: ");
            int n = num.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(num[i]+" ");
            }
        }

        /* The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
        and every other number in the sequence after it is the sum of the two numbers before it. So
        the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
        which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
        number: 2 + 3 = 5. This keeps going forever.
        The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
        Because one number is defined by the numbers before it, this sets up a perfect
        opportunity for using recursion.
        Your mission, should you choose to accept it, is to create a method called Fibonacci, which
        takes in a number and returns that number of the Fibonacci sequence. So if someone calls
        Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
        someone calls Fibonacci(8), it would return 21.
        In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
        sequence and print them out.
        Hint #1:Start with your base case. We know that if it is the 1st or 2nd number, the value will
        be 1.
        Hint #2:For every other item, how is it defined in terms of the numbers before it? Can you
        come up with an equation or formula that calls the Fibonaccimethod again?
      */
        public static int fib(int n)
        {
            if (n <= 2) return 1;
            else return fib(n-1) + fib(n-2);
        }
        private static void Main(string[] args)
        {
            /*
            int[] num = generatenumbers();
            Array.Reverse(num);
            print(num);
            */
            /*
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(fib(i)+" ");
            }
            */
            /*
            Department man1 = new Manager("Alice");
            Department man2 = new Manager("Bob");
            Department emp1 = new Employee("Clark");
            Department emp2 = new Employee("David");
            man1.displayname();
            man1.position();
            man2.displayname();
            man2.position();
            emp1.displayname();
            emp1.position();
            emp2.displayname();
            emp2.position();
            */

            /*
            Schooldepartment compSci = new Schooldepartment
            {
                Budget = 50000,
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 12, 31)
            };
            Course programming1 = new Course { Name = "C++" };
            Course programming2 = new Course { Name = "C#" };
            compSci.Courses.Add(programming1);
            compSci.Courses.Add(programming2);
            Instructor Alice = new Instructor("Alice", new DateTime(1970, 8, 7), 5000, new DateTime(2015, 9, 1),
                compSci);
            compSci.Head = Alice;
            Student studentBob = new Student("Bob", new DateTime(2000, 4, 20), 0);
            studentBob.Enrollcourse(programming1);
            studentBob.Enrollcourse(programming2);
            programming1.Enrolledstudents.Add(studentBob);
            programming2.Enrolledstudents.Add(studentBob);
            Alice.Address("Wavely Ave");
            Console.WriteLine($"Alice's salary with bonus: {Alice.Calsalary()}");
            Console.WriteLine($"Student Bob's age: {studentBob.Calage()}");
            Console.WriteLine("Bob is enrolled in the following courses:");
            foreach (var course in studentBob.GetCourses())
            {
                Console.WriteLine(course.Name);
            }
            */
            ConsoleApp2.Color red = new ConsoleApp2.Color(255, 0, 0, 0);
            ConsoleApp2.Color green = new ConsoleApp2.Color(0, 255, 0, 0);
            ConsoleApp2.Color blue = new ConsoleApp2.Color(0, 0, 255, 0);
            ConsoleApp2.Balls redball = new Balls(100, red);
            ConsoleApp2.Balls greenball = new Balls(200, green);
            ConsoleApp2.Balls blueball = new Balls(30, blue);
            redball.Throw();
            redball.Throw();
            redball.Throw();
            redball.Pop();
            redball.Throw();//red should be 3
            greenball.Throw();
            greenball.Pop();
            greenball.Throw();//green ball should be 1. 1 throw 1 pop become 0;
            blueball.Throw();
            blueball.Pop();
            blueball.Throw();
            blueball.Throw();
            blueball.Throw();//blue shoud be 1. the last 3 did not count because it has already poped.
            Console.WriteLine($"The red ball has been thrown {redball.GetThrowCount()} times.");
            Console.WriteLine($"The green ball has been thrown {greenball.GetThrowCount()} times.");
            Console.WriteLine($"The blue ball has been thrown {blueball.GetThrowCount()} times.");
        }
    }
}