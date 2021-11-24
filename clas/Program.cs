using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Your name is:\t"+kalameh(name)) ;
            Console.ReadKey();
        }
        public static string kalameh(string a)
        {
            
            char[] b = a.ToUpper().ToCharArray();
            char[] c = a.ToLower().ToCharArray();
            c[0] = b[0];
            a = "";
            for(int i = 0; i < c.Length;i++)
            {
                a = a + c[i];
            }

            
            return a;
        }
    }
}
