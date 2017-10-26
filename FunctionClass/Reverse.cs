using System;
using System.Text;
using System.Linq;

namespace FunctionClass
{
    public class Reverse
    {
        public string ReverseByArray(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public string ReverseByLINQ(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        public string ReverseManually(string input)
        {
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            return output;
        }

    }
}
