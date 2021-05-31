using ObserverPattern.Entities;
using ObserverPattern.Newsletter;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var _newsletterSender = new NewsletterSender();

            var employee = new Employee("Lucas Eschechola");
            var customer = new Customer("Gabriel Silva");
            var manager = new Manager("Mariana Eschechola");

            _newsletterSender.Attach(employee);
            _newsletterSender.Attach(customer);
            _newsletterSender.Attach(manager);

            _newsletterSender.ShowObservers();
            _newsletterSender.SendMails();

            _newsletterSender.Dettach(customer);

            _newsletterSender.ShowObservers();
            _newsletterSender.SendMails();

            Console.ReadKey();
        }
    }
}
