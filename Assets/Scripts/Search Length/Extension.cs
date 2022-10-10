using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExtensionMethod
{
    // 2. Реализовать метод расширения для поиска количество символов в строке.
    public static class Extension
    {
        public static int SearchOfLength(this string str)
        {
            int length = 0;
            for (int i = 0; i < str.Length; i++)
            {
                length++;
            }
            return length;
        }
    }
}