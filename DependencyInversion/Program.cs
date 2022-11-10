using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Burada yeni bir bildirim gönderen platform sınıfı eklense de, ana sınıf olan Noification üzerinde hiçbir değişiklik yapılmaz.
            Email email = new Email();
            email.Content = "Email içerik";
            email.Subject = "Subject";
            email.ToAddress = "asd@gmail.com";  
            Sms sms = new Sms();
            sms.Message = "call me";
            sms.PhoneNumber = "254559";
            List<INotification> notifications = new List<INotification>();
            notifications.Add(email);
            notifications.Add(sms);
            Notification notification = new Notification(notifications);
            notification.Send();
            Console.Read();
        }
    }
}
