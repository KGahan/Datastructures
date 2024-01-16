using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StringMirrored
    {
        Stack<char> stack1 = new Stack<char>();
        Stack<char> stack2 = new Stack<char>();

        public StringMirrored(Stack<char> _stack1, Stack<char> _stack2)
        {
            stack1 = _stack1;
            stack2 = _stack2;
        }

        public int stringMirrored(String word1, String word2)
        {
            char[] characters1 = word1.ToCharArray();
            char[] characters2 = word2.ToCharArray();

            foreach (char character1 in characters1)
            {
                stack1.Push(character1);
            }

            for (int i = characters2.Length-1; i >= 0; i--)
            {
                stack2.Push(characters2[i]);
            }

            for (int i = characters1.Length; i > 0; i--)
            {
                if(stack1.Pop() != stack2.Pop())
                {
                    return characters1.Length-i+1;
                }
            }
            return 0;
        }
    }
}
