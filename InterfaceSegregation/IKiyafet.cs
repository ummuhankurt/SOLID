using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IKiyafet
    {
        //Kazak, pantolon, elbise
        int Id { get; set; }
        string Tur { get; set; }
        string Renk { get; set; }
        double Fiyat { get; set; }
        char Size { get; set; } // Elbise için. Kazakta da olabilir. Pantolonda olmaz. 

    }
}
