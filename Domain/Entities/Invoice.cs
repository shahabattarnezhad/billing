using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class Invoice : BaseEntity<Guid>
{
    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public DateTime InvoiceDate { get; set; }

    public DateTime DueDate { get; set; }

    public int TotalAmount { get; set; }


    public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
    public ICollection<Payment>? Payments { get; set; }
}