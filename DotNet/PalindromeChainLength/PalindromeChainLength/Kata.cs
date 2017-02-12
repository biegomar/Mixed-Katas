using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChainLength
{
    public class Kata
    {
        public static int palindromeChainLength(int n)
        {
            var level = 0;
            var text = n.ToString();

            while (!isPalindrome(text))
            {
                text = specialStep(text);
                level++;
            }

            return level;
        }

        private static bool isPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }

            return text[0] == text[text.Length - 1] && isPalindrome(text.Substring(1, text.Length - 2));
        }

        private static string specialStep(string text)
        {
            var reverse = new string(text.Reverse().ToArray());
            var summand1 = Convert.ToInt64(text);
            var summand2 = Convert.ToInt64(reverse);
            var result = summand1 + summand2;

            return result.ToString();
        }
    }
}
