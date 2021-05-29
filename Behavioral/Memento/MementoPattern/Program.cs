using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(
                id: Guid.NewGuid(),
                customerDocument: "000.000.000-00",
                customerName: "Lucas G.",
                amountToPay: new Random().Next(100, 1500));

            Console.WriteLine("1 - State");
            Console.WriteLine("Id: {0}", invoice.Id.ToString());
            Console.WriteLine("Document: {0}", invoice.CustomerDocument);
            Console.WriteLine("Name: {0}", invoice.CustomerName);
            Console.WriteLine("Amount to pay: R$ {0:0.00}", invoice.AmountToPay);

            CareTaker caretaker = new CareTaker();
            caretaker.InvoiceMemento = invoice.SaveMemento();

            invoice.CustomerName = "Lucas E.";
            invoice.AmountToPay = new Random().Next(100, 1500);

            Console.WriteLine("\n\n2 - State");
            Console.WriteLine("Id: {0}", invoice.Id.ToString());
            Console.WriteLine("Document: {0}", invoice.CustomerDocument);
            Console.WriteLine("Name: {0}", invoice.CustomerName);
            Console.WriteLine("Amount to pay: R$ {0:0.00}", invoice.AmountToPay);

            invoice.RestoreMemento(caretaker.InvoiceMemento);

            Console.WriteLine("\n\n3 - State");
            Console.WriteLine("Id: {0}", invoice.Id.ToString());
            Console.WriteLine("Document: {0}", invoice.CustomerDocument);
            Console.WriteLine("Name: {0}", invoice.CustomerName);
            Console.WriteLine("Amount to pay: R$ {0:0.00}", invoice.AmountToPay);

            Console.ReadKey();
        }
    }
}
