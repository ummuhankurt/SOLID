using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Bmw : Araba, IKlima
    {
        public string Klima()
        {
            return "Bmw nin kliması çalıştı";
        }
    }
}
