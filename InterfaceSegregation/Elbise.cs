using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Elbise : IKiyafet
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public double Fiyat { get; set; }
        public string EnBoy { get; set; }
        public char Size { get; set; }
        public string Desen { get; set; }
        public string Kumas { get; set; }
    }
}
