using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algos
{
    public class HighestAndLowest
    {
        #region MyRegion
        /*In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

            Examples
            Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
        Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        Notes
            All numbers are valid Int32, no need to validate them.
            There will always be at least one number in the input string.
        Output string must be two numbers separated by a single space, and highest number is first.*/

            #endregion


            public static class Kata
            {
                public static string HighAndLow(string numbers)
                {
                    string[] temp = numbers.Split(" ");

                    int min = 0;
                    int max = 0;
                    int check;

                    for (int i = 0; i < temp.Length; i++)
                    {
                        string current = temp[i];
                        int.TryParse(current, out check);
                        if (check > max) max = check;
                        else if (check < min) min = check;
                    }
                    
                    return max + " " + min;
                }

                public static string HighAndLowTwo(string numbers)
                {
                    var temp = numbers.Split(" ").Select(x => Convert.ToInt32(x));
                    return temp.Max() + " " + temp.Min();
                }
            }

}
}
