using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public abstract class Araba
    {
        // public abstract string Start(); :> Böyle olsaydı alt sınıfların hepsinde bu metod ezilirdi.
        public string Start() // Bütün arabaların start() metodu aynı olduğu için metodu abstract tanımlamadık.
        {
            return "Çalıştı";
        }
    }
}
