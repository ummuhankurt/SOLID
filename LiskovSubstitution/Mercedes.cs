using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Mercedes : Araba, IKlima
    {
        public string Klima()
        {
            return "Mercedesin kliması çalıştı";
        }
    }
}
