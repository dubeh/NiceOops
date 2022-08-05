using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterFirstApp
{
    internal class Utility
    {
        public static void create(params string[] strs)
        {
            string sentence = string.Empty;
            foreach (var item in strs)
            {
                sentence += $"{item}";

            }
            Console.WriteLine(sentence);
        }
        public static void getwordcount(string[] strarray)
        {
            Console.WriteLine($"strarray has {strarray.Length} items in it");
        }

        public static bool isEmpty(string? str, int? num)
        {
            return string.IsNullOrEmpty(str) || num == null;
        }

        public static string[] getnames()
        {
            //string[] names = new string[3];
            //names[0] = "p";
            //names[1] = "a";
            //names[2] = "r";

            string[] names = new string[] { "p", "a", "r" };
            return names;
        }

        public static int[] getage()
        {
            int[] age = new int[] { 1, 2, 3, 4 };
            return age;
        }

        public static int increment(int num = 0)
        {
            num += 1;
            num++;
            return num;
        }

        public static Int32 Add(Int32 num1, Int32 num2)
        {
            return num1 + num2;
        }
        public static Int32 Subtract(Int32 num1, Int32 num2)
        {
            return num1 - num2;
        }
        public static Int32 Multiply(Int32 num1, Int32 num2)
        {
            return num1 * num2;
        }
        public static Int32 Divide(Int32 num1, Int32 num2)
        {
            return num1 / num2;
        }
    }
}
