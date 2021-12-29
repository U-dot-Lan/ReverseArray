using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseArray
{
    public static class RA
    {
        public static void ReverseArray(string[] str)
        {
            int length = (str.Length + 1) / 2;
            for (int i = 0, j = str.Length - 1; i < length;  i++, j--)
            {
                string temp = str[i];
                str[i] = str[j];
                str[j] = temp;
            }
        }
    }
}
