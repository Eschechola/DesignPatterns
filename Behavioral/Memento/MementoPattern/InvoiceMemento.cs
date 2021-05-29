using System;

namespace MementoPattern
{
    public class InvoiceMemento
    {
        public Guid Id { get; set; }
        public string CustomerDocument { get; set; }
        public string CustomerName { get; set; }
        public decimal AmountToPay { get; set; }
        public DateTime CreatedAt { get; set; }

        public InvoiceMemento(Guid id, string customerDocument, string customerName, decimal amountToPay)
        {
            Id = id;
            CustomerDocument = customerDocument;
            CustomerName = customerName;
            AmountToPay = amountToPay;
            CreatedAt = DateTime.Now;
        }
    }
}
