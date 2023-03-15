using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random password generator.
            int s;
            char[] chars = { 'A', 'B', 'C', 'D', 'F', 'K', 'L', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', '&', '!', '#', '*' };
            Random r= new Random();
            Console.Write("Random password generated: ");
            for (int i=1; i<10; i++)
            {
                s=r.Next(chars.Length);
                Console.Write("{0}", chars[s]);
            }
            Console.Read();
        }
    }
}
