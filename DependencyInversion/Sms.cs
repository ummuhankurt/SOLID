using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Sms : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void Send()
        {
            Console.WriteLine("Sms gönderildi");
            Console.WriteLine("Telefon numarası : " + PhoneNumber + " Mesaj : " + Message);
        }
    }
}
