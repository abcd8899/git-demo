using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloGit
{
    public static class ReverseTask
    {
        public static string ReverseUebung(string input)
        {
            if (!input.ToLower().Equals("Stefan".ToLower()))
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);

            }
            return input;
        }
    }
}
