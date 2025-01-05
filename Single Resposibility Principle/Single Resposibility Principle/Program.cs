using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Resposibility_Principle
{
    public class SMS_Service
    {
        public static void Send(string to, string sms)
        {
            Console.WriteLine($"SMS Service => To : {to}, SMS : {sms}");
        }
    }
    public class FAX_Service
    {
        public static void Send(string to, string fax)
        {
            Console.WriteLine($"FAX Service => To : {to}, FAX : {fax}");
        }
    }
    public class Email_Service
    {
        public static void Send(string to, string message)
        {
            Console.WriteLine($"Email Service => To : {to}, Message : {message}");
        }
    }
    public class NotificationService
    {
        public enum enNotificationType { EMAIL = 1, SMS, FAX };
        public void SendNotification(enNotificationType type, string to, string message)
        {
            if (type == enNotificationType.EMAIL)
            {
                Email_Service.Send(to, message);
            }
            else if (type == enNotificationType.SMS)
            {
                SMS_Service.Send(to, message);
            }
            else if (type == enNotificationType.FAX)
            {
                FAX_Service.Send(to, message);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();

            notificationService.SendNotification(NotificationService.enNotificationType.EMAIL, "diyahabdo@gmail.com", "Hello Diyaeddin");
            notificationService.SendNotification(NotificationService.enNotificationType.FAX, "123-456-789", "Hello Martin");
            notificationService.SendNotification(NotificationService.enNotificationType.SMS, "232-122-222", "Hello Alex");

            Console.ReadKey();
        }
    }
}
