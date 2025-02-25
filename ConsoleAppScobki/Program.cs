using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScobki
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = Console.ReadLine();
            Stack<string> itog = new Stack<string> { };
            if (stroka != null)
            {
                foreach (char ch in stroka)
                {
                    if (ch == '(')
                        itog.Push(Convert.ToString(ch));
                    else if (ch == ')')
                    {
                        if (itog.Count == 0)
                        {
                            Console.WriteLine("NO");
                            goto use;
                        }
                        itog.Pop();
                    }
                }
                if (itog.Count == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
                use:;
            }
            else
                Console.WriteLine("YES");
        }
    }
}
