using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] { "h", "e", "l", "l", "o" };
            RA.ReverseArray(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
        }
    }
}
