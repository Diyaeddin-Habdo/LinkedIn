using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public interface INotificationService
    {
        void Send(string to, string message);
    }
    public class SMS_Service : INotificationService
    {
        public void Send(string to, string sms)
        {
            Console.WriteLine($"SMS Service => To : {to}, SMS : {sms}");
        }
    }
    public class FAX_Service : INotificationService
    {
        public void Send(string to, string fax)
        {
            Console.WriteLine($"FAX Service => To : {to}, FAX : {fax}");
        }
    }
    public class Email_Service : INotificationService
    {
        public void Send(string to, string message)
        {
            
        }
    }

    public class WhatsApp_Service : INotificationService
    {
        public void Send(string to, string message) 
        {
            Console.WriteLine($"WhatsApp Service => To : {to}, Message : {message}");
        }
    }
    public class NotificationService
    {
        private INotificationService _notificationService;

        public NotificationService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification(string to, string message)
        {
           _notificationService.Send(to, message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService Sender = new NotificationService( new SMS_Service());
            Sender.SendNotification("232-122-222", "Hello Alex");

            Sender = new NotificationService( new FAX_Service());
            Sender.SendNotification("123-456-789", "Hello Martin");

            Sender = new NotificationService(new  Email_Service());
            Sender.SendNotification("diyahabdo@gmail.com", "Hello Diyaeddin");


            Sender = new NotificationService(new WhatsApp_Service());
            Sender.SendNotification("12345678912", "Hi whats up ?");

            Console.ReadKey();
        }
    }
}