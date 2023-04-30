using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OzonContext.Competition
{
    public static class TestB
    {
        static char[] glas = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
        public static char[] second = new char[] { 's', 'h', 'x', 'z' };
        public static void Main(string[] args)
        {
            var testCaseCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCaseCount; i++)
            {
                var word = Console.ReadLine().ToCharArray();
                var last = word[word.Length - 1];
                var prelast = word[word.Length - 2];
                if (second.Contains(last))
                {
                    if (last == 'h' && !(prelast == 's' || prelast == 'c'))
                    {
                        var res = new string(word);
                        Console.WriteLine(res + "s");
                    }
                    else
                    {
                        var res = new string(word);
                        Console.WriteLine(res + "es");
                    }
                }

                else
                {
                    if (last == 'y' && !glas.Contains(prelast))
                    {
                        var res = new string(word);
                        var newWord = res.Substring(0, word.Length - 1);
                        Console.WriteLine(newWord + "ies");
                    }

                    else

                    {
                        var res = new string(word);
                        Console.WriteLine(res + "s");
                    }
                }
            }
        }
    }
    }

