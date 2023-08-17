using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    /*
     * Challenge name: longest-valid-parentheses
        Description: 

        Given a string containing just the characters ’(’ and ’)’, find the length of the longest
        valid (well-formed) parentheses substring.

        For "(()", the longest valid parentheses substring is "()", which has length = 2. 
        Another example is ")()())", where the longest valid parentheses substring is "()()", which
        has length = 4.

     */
    public static class LongestValidParentheses
    {
        public static int FindLength(string characters)
        {
            if (string.IsNullOrEmpty(characters))
                return 0;

            var characterToCheck = '(';
            int result = 0;
            var stack = new Stack<int>();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == characterToCheck)
                    stack.Push(i);

                else if (stack.Any() && characters[stack.Peek()] == characterToCheck)
                {
                    stack.Pop();
                    result = Math.Max(result, i - (stack.Any() ? stack.Peek() : -1));
                }
                else
                    stack.Push(i);
            }
            return result;
        }

        public static string FindLength2(string characters)
        {
            if (string.IsNullOrEmpty(characters))
                return string.Empty;
            
            var validParenthesis = new List<string>();
            for (int i = 0; i < characters.Length; i++)
            {
                var nextCharacter = i + 1;
                if (characters[i] == '(' && characters[nextCharacter] == ')')                                
                    validParenthesis.Add("()");                               
            }     
            return string.Join("", validParenthesis);
        }
    }
}
