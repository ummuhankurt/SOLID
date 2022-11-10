using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bmw bmw = new Bmw();
            Mercedes mercedes = new Mercedes();
            Serce serce = new Serce();
            Console.WriteLine(bmw.Klima());
            Console.WriteLine(bmw.Start());
            Console.WriteLine(mercedes.Klima());
            Console.WriteLine(mercedes.Start());
            Console.WriteLine(serce.Start());
            Console.ReadKey();
        }
    }
}
