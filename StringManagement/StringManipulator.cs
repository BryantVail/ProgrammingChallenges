using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManagement
{
    public class StringManipulator
    {
        public static string ReverseString(ref string value)
        {
            Stack<char> stringStack = new Stack<char>();

            for(int i = 0; i < value.Length; i++)
            {
                stringStack.Push(value[i]);
            }

            char[] charactersReversed = new char[stringStack.Count];
            for (int i = 0; i < value.Length; i++)
            {
                charactersReversed[i] = stringStack.Pop();
            }
            return new String(charactersReversed);
        }

        public static string ReverseString(string value)
        {
            return ReverseString(ref value);
        }
    }
}