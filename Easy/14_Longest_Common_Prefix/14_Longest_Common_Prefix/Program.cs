using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string LongestCommonPrefix(string[] strs)
            {
                if (strs.Length == 0)
                {
                    return "";
                }

                if (strs.Length == 1)
                {
                    return strs[0];
                }

                int minStringLength = Int32.MaxValue;

                for (int k = 0; k < strs.Length; k++)
                {
                    if (strs[k].Length < minStringLength)
                    {
                        minStringLength = strs[k].Length;
                    }
                }

                for (int i = minStringLength; i > 0; i--)
                {
                    var subStr = strs[0].Substring(0, i);
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (strs[j].Length == 0)
                        {
                            return "";
                        }
                        if (strs[j].Substring(0, i) != subStr)
                        {
                            break;
                        }
                        if (j == strs.Length - 1 && strs[j].Substring(0, i) == subStr)
                        {
                            return subStr;
                        }
                    }
                }
                return "";
            }
            // var resultStr = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            var resultStr = LongestCommonPrefix(new string[] { "flower", "flower", "flower" });
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
