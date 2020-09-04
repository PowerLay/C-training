using System;

namespace SortString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] arr = s.Split(' ');
            Array.Sort(arr);
            s = string.Join(" ", arr);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}