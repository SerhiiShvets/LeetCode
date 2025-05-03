using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Find_Index_of_First_Occurrence_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int StrStr(string haystack, string needle)
            {
                if (haystack.Length == needle.Length)
                {
                    return haystack == needle ? 0 : -1;
                }
                else
                {
                    for (int i = 0; i <= haystack.Length - needle.Length; i++)
                    {
                        if (haystack.Substring(i, needle.Length) == needle)
                        {
                            return i;
                        }
                    }
                }
                return -1;
            }
            var result = StrStr("sadbutsad", "sad");
            Console.WriteLine(result);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
