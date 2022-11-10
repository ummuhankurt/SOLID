using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Email : INotification
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void Send()
        {
            Console.WriteLine("Email gönderildi");
            Console.WriteLine("Kimden :" + ToAddress + " Konu : " + Subject + " içerik : " + Content);
        }
    }
}
