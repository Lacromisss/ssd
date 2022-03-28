using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    internal  static class ExtentionMethods
    {
        public static bool IsOdd( this int number)
        {
            if (number % 2 != 0)
            {
                return true;


            }
            return false;

        }
        public static bool IsEven( this int number)
        {
            if (number % 2 == 0)
            {
                return true;


            }
            return false;
        }
        public static bool IsContainsDigit( this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    return true ;

                }
            }
            return false ;
        }


        public static string ToCapitalize( this string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            if (value.Length == 0)
                return value;
            StringBuilder result = new StringBuilder(value);
            result[0] = char.ToUpper(result[0]);
            for (int i = 1; i < result.Length; ++i)
            {
                if (char.IsWhiteSpace(result[i - 1]))
                    result[i] = char.ToUpper(result[i]);
            }

            return result.ToString();
        }
        public static int[] GetValueIndexes( this   string b ,  char a)
        {
           
            int count = 0;
            int[] arrs= new int[0];
            
            for (int i = 0; i <b.Length; i++)
            {
                count++;
                if (b[i]==a)
                {
                   
                    Array.Resize(ref arrs, arrs.Length + 1);
                    arrs[arrs.Length - 1] = count;



                }
                
                 
                

            }
            return arrs;




        }
    }
    }

