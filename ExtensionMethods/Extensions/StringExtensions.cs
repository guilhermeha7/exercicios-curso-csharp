using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisStr, int number)
        {
            if (thisStr.Length <= number)
            {
                return thisStr;
            }
            else
            {
                return thisStr.Substring(0, number) + "...";
            }
        }
    }
}
