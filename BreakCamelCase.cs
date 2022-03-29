using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class BreakCamelCase
    {
        #region Question
        //Complete the solution so that the function will break up camel casing, using a space between words.
        /*Example
        "camelCasing"  =>  "camel Casing"
        "identifier"   =>  "identifier"
        ""             =>  ""*/
        #endregion

        public class Kata
        {
            public static string BreakCamelCase(string str)
            {
                string word = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                    {
                        word += str[i];
                    }
                    else word += " " + str[i];
                }
                return word;
                // complete the function
            }
        }
    }
}
