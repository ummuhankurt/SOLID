using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Pantolon pantolon = new Pantolon();
            // pantolon.Yaka = ? Pantolonda yaka diye bir şey yok.
            pantolon.Id = 1;
            pantolon.PacaYapilacakMi = true;
            pantolon.Tur = "Kadın Pantolon";
            pantolon.EnBoy = "26-24";
            Console.WriteLine(pantolon.Id);
            Console.WriteLine(pantolon.PacaYapilacakMi);
            Console.WriteLine(pantolon.Tur);
            Console.WriteLine(pantolon.EnBoy);
            Console.Read();
        }
    }
}
