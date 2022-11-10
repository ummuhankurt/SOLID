using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Notification
    {
        private ICollection<INotification> _notifications;
        public Notification(ICollection<INotification> notifications)
        {
            this._notifications = notifications;
        }
        public void Send()
        {
            foreach (var item in _notifications)
            {
                item.Send();
            }
        }
    }
}
