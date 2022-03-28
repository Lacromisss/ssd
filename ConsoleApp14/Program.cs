using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number.IsOdd());
            Console.WriteLine(number.IsEven());
            //----------------------------------------
            string word = "mustafa qasimazde";
            char chars = 'a';
            Console.WriteLine( word.IsContainsDigit());
            Console.WriteLine(word.ToCapitalize());
            var arrs = word.GetValueIndexes(chars);
            foreach (var item in arrs)
            {
                Console.WriteLine(item);

            }
















        }

    }
}
