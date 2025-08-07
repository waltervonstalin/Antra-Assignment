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
    /*1. FizzBuzzis a group word game for children to teach them about division.Players take turns
   to count incrementally, replacing any number divisible by three with the word /fizz/, any
   number divisible by five with the word /buzz/, and any number divisible by both with /
   fizzbuzz/.
   Create a console application in Chapter03 named Exercise03 that outputs a simulated
   FizzBuzz game counting up to 100. The output should look something like the following
   screenshot:
   What will happen if this code executes?*/

    public static void fizzbuzz()
    {
        for (int i = 0; i < 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("fizzbuzz");
            else if (i % 3 == 0) Console.WriteLine("fizz");
            else if (i % 5 == 0) Console.WriteLine("buzz");
            else Console.WriteLine(i);
        }
        return;
    }

    /* What will happen if this code executes?


              int max = 500;
              for (byte i = 0; i<max; i++) // i is of type byte, which has a maximum value of 255. Since max is set to 500, the loop will result in an overflow,
              {
                  Console.WriteLine(i); // This is not recognised because Console is missing
              }
    The code you’ve provided will result in an infinite loop because the byte data type has a maximum value of 255. When i reaches 255 and is incremented, it will overflow and wrap around back to 0, causing the loop to continue indefinitely.

       ##### Warning Code: To warn about the problem without changing the existing code, you could add a check to see if i has wrapped around:
       if (i == 255){
           Console.WriteLine("Warning: 'byte' type will overflow and wrap around.");
    break; // Exit the loop
       }
     */

    /*  Write a program that generates a random number between 1 and 3 and asks the user to
    guess what the number is. Tell the user if they guess low, high, or get the correct answer.
    Also, tell the user if their answer is outside of the range of numbers that are valid guesses
    (less than 1 or more than 3). You can convert the user's typed answer from a string to an
    int using this code:
    */

    public static void guessgame() {
        int num = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number between 1 and 3:");
        int guess = int.Parse(Console.ReadLine());
        if (guess < 1 || guess > 3) Console.WriteLine("Your number is not valid");
        else if (guess == num) Console.WriteLine("You get the correct answer");
        else if (guess > num) Console.WriteLine("Your number is too big");
        else Console.WriteLine("Your number is too small");
        return;
    }

    /*
   * Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
     will print the following pattern: If you find yourself getting stuck, try recreating the two
     examples that we just talked about in this chapter first. They’re simpler, and you can
     compare your results with the code included above.
     This can actually be a pretty challenging problem, so here is a hint to get you going. I used
     three total loops. One big one contains two smaller loops. The bigger loop goes from line
     to line. The first of the two inner loops prints the correct number of spaces, while the
     second inner loop prints out the correct number of stars.
   */
    public static void pyramid()
    {
        Console.WriteLine("Please input yout pyramid's height: ");
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            for (int j = height; j > i; j--) Console.Write(" ");
            for (int k = 1; k <= (2 * i - 1); k++) Console.Write("*");
            Console.WriteLine();
        }
        return;
    }

    /*
     * Write a simple program that defines a variable representing a birth date and calculates
       how many days old the person with that birth date is currently.
       For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
       Note: once you figure out their age in days, you can calculate the days until the next
       anniversary using int daysToNextAnniversary = 10000 - (days % 10000); 
     */

    public static void anniversary()
    {
        Console.WriteLine("Enter your birthday:");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int days = (today - birthdate).Days;
        Console.WriteLine($"You are {days} days old");
        int anniversary = 10000 - (days % 10000);
        DateTime next = today.AddDays(anniversary);
        Console.WriteLine($"Your next 10000 day anniversary will be on {next.ToShortDateString()}.");
    }

    /*
    * Write a program that greets the user using the appropriate greeting for the time of day.
      Use only if , not else or switch , statements to do so. Be sure to include the following
      greetings:
      "Good Morning"
      "Good Afternoon"
      "Good Evening"
      "Good Night"
      It's up to you which times should serve as the starting and ending ranges for each of the
      greetings. If you need a refresher on how to get the current time, see DateTime
      Formatting. When testing your program, you'll probably want to use a DateTime variable
      you define, rather than the current time. Once you're confident the program works
      correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
      assign DateTime.Now as its value, which is often a better approach).
    */
    public static void greetings()
    {
        //int test = int.Parse(Console.ReadLine());
        DateTime dateTime = DateTime.Now;
        int hour = dateTime.Hour;
        if (hour >= 6 && hour <= 12) Console.WriteLine("Good Morning");
        else if (hour > 12 && hour <= 18) Console.WriteLine("Good Afternoon");
        else if (hour > 18 && hour <= 22) Console.WriteLine("Good Evening");
        else if (hour > 22 || hour < 6) Console.WriteLine("Good Night");
    }

    /* Write a program that prints the result of counting up to 24 using four different increments.
       First, count by 1s, then by 2s, by 3s, and finally by 4s.
       Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
       count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
       loop control variable/ from the outer loop.This means the incrementing in the /
       afterthought/ expression will be based on a variable.
       Your output should look something like this:
     */

    public static void counting()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Counting by {i}s:");
            for (int j = 0; j <= 24; j += i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine("\n");
        }
    }

    /* Arrays and Strings
       Copying an Array
       Write code to create a copy of an array.First, start by creating an initial array. (You can use
       whatever type of data you want.) Let’s start with 10 items.Declare an array variable and
       assign it a new array with 10 items in it.Use the things we’ve discussed to put some values
       in the array.
       Now create a second array variable.Give it a new array with the same length as the first.
       Instead of using a number for this length, use the Lengthproperty to get the size of the
       original array.
       Use a loop to read values from the original array and place them in the new array.Also
       print out the contents of both arrays, to be sure everything copied correctly.
     */

    public static void copy()
    {
        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] cpyarray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            cpyarray[i] = array[i];
        }
        Console.WriteLine("Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Copied Array:");
        for (int i = 0; i < cpyarray.Length; i++)
        {
            Console.Write(cpyarray[i] + " ");
        }
        Console.WriteLine();
    }

    /* Write a simple program that lets the user manage a list of elements.It can be a grocery list,
       "to do" list, etc.Refer to Looping Based on a Logical Expression if necessary to see how to
       implement an infinite loop.Each time through the loop, ask the user to perform an
       operation, and then show the current contents of their list.The operations available should
       be Add, Remove, and Clear.The syntax should be as follows:
       + some item
       - some item
       --
       Your program should read in the user's input and determine if it begins with a “+” or “-“ or
       if it is simply “—“ . In the first two cases, your program should add or remove the string
       given("some item" in the example). If the user enters just “—“ then the program should
       clear the current list.Your program can start each iteration through its loop with the
       following instruction:
       Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
     */

    public static void mamange()
    {
        List<string> itlist = new List<string>();
        string input;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Enter your command: +item, -item ,-- to clear or exit to quit");
            input = Console.ReadLine();
            if (input.StartsWith("+"))
            {
                itlist.Add(input.Substring(1).Trim());
            }
            else if (input.StartsWith("-") && input != "--")
            {
                string remove = input.Substring(1).Trim();
                if (itlist.Contains(remove))
                {
                    itlist.Remove(remove);
                }
                else Console.WriteLine("items not found");
            }
            else if (input == "--") itlist.Clear();
            else if (input.ToLower() == "exit")
            {
                exit = true;
                continue;
            }
            else Console.WriteLine("Invaild Command");
            Console.WriteLine("Current List:");
            foreach (string it in itlist) Console.WriteLine(it);
        }
    }
    /* Write a method that calculates all prime numbers in given range and returns them as array
       of integers
       static int[] FindPrimesInRange(startNum, endNum)
    {
    }
     */

    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (prime(i) == true) primes.Add(i);
        }
        foreach (int i in primes) Console.Write(i + " ");
        return primes.ToArray();
    }
    public static bool prime(int i)
    {
        if (i <= 1) return false;
        if (i == 2) return true;
        if (i % 2 == 0) return false;
        for (int j = 3; j < i; j += 2)
        {
            if (i % j == 0) return false;
        }
        return true;
    }

    /*  Write a program to read an array of n integers (space separated on a single line) and an
       integer k, rotate the array right k times and sum the obtained arrays after each rotation as
       shown below.
       After r rotations the element at position I goes to position (I + r) % n.
       The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
     */

    public static void rotation()
    {
        Console.WriteLine("Enter the integers:");
        int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Console.WriteLine("Enter the rotation times:");
        int r = int.Parse(Console.ReadLine());
        int[] sum = new int[num.Length];
        for (int i = 1; i <= r; i++)
        {
            int[] rarray = rotate(num, i);
            for (int j = 0; j < num.Length; j++) sum[j] += rarray[j];
        }
        Console.WriteLine("The Sum of Array is:");
        Console.WriteLine(string.Join(" ", sum));
    }
    public static int[] rotate(int[] array, int rotation)
    {
        int n = array.Length;
        int[] rarray = new int[array.Length];
        for (int i = 0; i < n; i++)
        {
            rarray[(i + rotation) % n] = array[i];
        }
        return rarray;
    }

    /*Write a program that finds the longest sequence of equal elements in an array of integers.
      If several longest sequences exist, print the leftmost one.
     */
    public static void longestseq()
    {
        Console.WriteLine("Enter the integers:");
        int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = num.Length;
        int head = 0, tail = head + 1, st = 0, ed = 0, lg = 1;
        while (tail < n)
        {
            if (num[head] == num[tail])
            {
                while (tail < n && num[head] == num[tail]) tail++;
                int len = tail - head;
                if (len > lg)
                {
                    st = head; ed = tail - 1; lg = len;
                }
            }
            head = tail;
            tail++;
        }
        Console.WriteLine("The longest sequence is:");
        for (int i = st; i <= ed; i++) Console.Write(num[i] + " ");
    }
    /* Write a program that finds the most frequent number in a given sequence of numbers.In
      case of multiple numbers with the same maximal frequency, print the leftmost of them
    */
    public static void mostfreq()
    {
        Console.WriteLine("Enter the integers:");
        int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int n = num.Length;
        Dictionary<int, int> count = new Dictionary<int, int>();
        int max = 0, maxnum = num[0];
        foreach (int i in num) {
            if (count.ContainsKey(i)) count[i]++;
            else count[i] = 1;
            if (count[i] > max)
            {
                max = count[i];
                maxnum = i;
            }
            else if (count[i] == max && num.ToList().IndexOf(i) < num.ToList().IndexOf(maxnum)) maxnum = i;
        }
        Console.WriteLine($"The most frequent number is: {maxnum}");
    }

    /* Write a program that reads a string from the console, reverses its letters and prints the
       result back at the console.
       Write in two ways
       - Convert the string to char array, reverse it, then convert it to string again
       - Print the letters of the string in back direction (from the last to the first) in a for-loop
     */
    public static void reverse()
    {
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        string output = new string(array);
        Console.WriteLine("The char array reverse output is:");
        Console.WriteLine(output);
        int n = input.Length;
        Console.WriteLine("The for loop reverse output is:");
        for (int i = n - 1; i >= 0; i--) Console.Write(input[i]);
        return;
    }

    /* Write a program that reverses the words in a given sentence without changing the
      punctuation and spaces
      - Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
      - All other characters are considered part of words, e.g.C++, a+b, and a77 are
      considered valid words.
      - The sentences always start by word and end by separator.
    */
    public static void reversewords()
    {
        Console.WriteLine("Enter the sentence:");
        string sentence = Console.ReadLine();
        string[] separators = { ".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?", " " };
        string pattern = "(\\.|,|:|;|=|\\(|\\)|&|\\[|\\]|\"|'|\\\\|/|!|\\?| )";
        string[] words = Regex.Split(sentence, pattern);
        var wordList = new List<string>();
        var separatorsList = new List<string>();
        foreach (string word in words)
        {
            if (string.IsNullOrEmpty(word)) continue;
            if (separators.Contains(word))
            {
                separatorsList.Add(word);
            }
            else
            {
                wordList.Add(word);
            }
        }
        wordList.Reverse();
        StringBuilder result = new StringBuilder();
        int wordIndex = 0;
        int sepIndex = 0;
        foreach (string part in words)
        {
            if (string.IsNullOrEmpty(part)) continue;
            if (separators.Contains(part))
            {
                result.Append(part);
                sepIndex++;
            }
            else
            {
                if (wordIndex < wordList.Count)
                {
                    result.Append(wordList[wordIndex]);
                    wordIndex++;
                }
            }
        }
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(result.ToString());
    }
    /* Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
       and prints them on the console on a single line, separated by comma and space.Print all
       unique palindromes (no duplicates), sorted
     */
         public static List<string> extractPalindromes(string text)
    {
        var words = text.Split(new[] { ' ', ',', '.', '?', '!', ';', ':', '-', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        var palindromes = new HashSet<string>();

        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word.ToLower());
            }
        }

        return palindromes.OrderBy(p => p).ToList();
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (char.ToLower(word[left]) != char.ToLower(word[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
    /* Write a program that parses an URL given in the following format:
      [protocol]://[server]/[resource]
      The parsing extracts its parts: protocol, server and resource.
      The[server] part is mandatory.
      The[protocol] and[resource] parts are optional.
    */
    public static void url()
    {
        Console.WriteLine("Enter the url of website: ");
        string url = Console.ReadLine();
        string protocol = "";
        string server = "";
        string resource = "";
        int protocolEnd = url.IndexOf("://");
        if (protocolEnd != -1)
        {
            protocol = url.Substring(0, protocolEnd);
            url = url.Substring(protocolEnd + 3);
        }
        int serverEnd = url.IndexOf("/");
        if (serverEnd != -1)
        {
            server = url.Substring(0, serverEnd);
            resource = url.Substring(serverEnd + 1);
        }
        else server = url;
        Console.WriteLine($"Protocol: {protocol}");
        Console.WriteLine($"Server: {server}");
        Console.WriteLine($"Resource: {resource}");
    }
private static void Main(string[] args)
    {
        //fizzbuzz();
        //guessgame();
        //pyramid();
        //anniversary();
        //greetings();
        //counting();
        //copy();
        //mamange();
        //FindPrimesInRange(-101, 10000);
        //rotation();
        //longestseq();
        //mostfreq();
        //reverse();
        //reversewords();
        //extractPalindromes();
        url();
    }
}