using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Palindrom
    {
        Stack<char> stack = new Stack<char>();

        public Palindrom (Stack<char> _stack)
        {
            stack = _stack;
        }

        public bool checkPalindrom(String word)
        {
            char[] characters = word.ToCharArray();

            foreach (char character in characters)
            {
                stack.Push(character);
            }

            for (int i = 0; i < characters.Length; i++)
            {
                char poppedChar = stack.Peek();
                stack.Pop();

                if (poppedChar != characters[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
