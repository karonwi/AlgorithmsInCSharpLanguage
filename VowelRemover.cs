using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class VowelRemover
    {
        #region Question
        //Create a function called shortcut to remove the lowercase vowels(a, e, i, o, u ) in a given string.
        /*Examples
        "hello"     -->  "hll"
        "codewars"  -->  "cdwrs"
        "goodbye"   -->  "gdby"
        "HELLO"     -->  "HELLO"*/
        #endregion
        public class Kata
        {
            public static string Shortcut(string input)
            {
                // TODO: Remove vowels
                string check = "";
                for (int i = 0; i < input.Length; i++)
                {
                    if (!("aeiou".Contains(input[i])))
                    {
                        check += input[i];
                    }
                }
                return check;
            }
        }

    }
}
