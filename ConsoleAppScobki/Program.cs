using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScobki
{
    class Program
    {
        static bool balanceDiffrentBrackets(string s)
        {
            Stack<char> balance = new Stack<char>();
            Dictionary<char, char> endBrackets = new Dictionary<char, char>
            {
                ['(']=')',['{']='}',['['] = ']',['<'] = '>'
            };
            foreach(var bracket in s)
            {
                if (endBrackets.ContainsKey(bracket))
                    balance.Push(bracket);
                else
                {
                    if (balance.Count > 0)
                    {
                        char bracketOnTop = balance.Peek();
                        if (bracket == endBrackets[bracketOnTop])
                            balance.Pop();
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
            if (balance.Count == 0)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            //string stroka = Console.ReadLine();
            //Stack<string> itog = new Stack<string> { };
            //if (stroka != null)
            //{
            //    foreach (char ch in stroka)
            //    {
            //        if (ch == '(')
            //            itog.Push(Convert.ToString(ch));
            //        else if (ch == ')')
            //        {
            //            if (itog.Count == 0)
            //            {
            //                Console.WriteLine("NO");
            //                goto use;
            //            }
            //            itog.Pop();
            //        }
            //    }
            //    if (itog.Count == 0)
            //        Console.WriteLine("YES");
            //    else
            //        Console.WriteLine("NO");
            //    use:;
            //}
            //else
            //    Console.WriteLine("YES");
            string b = "()";
            Console.WriteLine(balanceDiffrentBrackets(b));
        }
    }
}
