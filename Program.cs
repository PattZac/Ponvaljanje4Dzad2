using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi niz znakova: ");
            string str = Console.ReadLine().Replace(' ', '_');
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
