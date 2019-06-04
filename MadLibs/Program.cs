using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are {0}", color);
            Console.WriteLine("{0} are blue", pluralNoun);
            Console.WriteLine("I love {0}", celebrity);

            Console.ReadLine();
        }
    }
}
