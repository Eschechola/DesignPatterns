using System;

namespace MementoPattern
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string CustomerDocument { get; set; }
        public string CustomerName { get; set; }
        public decimal AmountToPay { get; set; }

        public Invoice()
        { }

        public Invoice(Guid id, string customerDocument, string customerName, decimal amountToPay)
        {
            Id = id;
            CustomerDocument = customerDocument;
            CustomerName = customerName;
            AmountToPay = amountToPay;
        }

        public InvoiceMemento SaveMemento()
        {
            Console.WriteLine("Saving memento...");
            
            return new InvoiceMemento(Id, CustomerDocument, CustomerName, AmountToPay);
        }

        public void RestoreMemento(InvoiceMemento invoiceMemento)
        {
            Console.WriteLine("Restoring state...");

            Id = invoiceMemento.Id;
            CustomerDocument = invoiceMemento.CustomerDocument;
            CustomerName = invoiceMemento.CustomerName;
            AmountToPay = invoiceMemento.AmountToPay;
        }
    }
}
