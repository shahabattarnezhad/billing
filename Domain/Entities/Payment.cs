using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class Payment : BaseEntity<Guid>
{
    public Guid PaymentMethodId { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }

    public Guid PaymentStatusId { get; set; }
    public PaymentStatus? PaymentStatus { get; set; }

    public Guid InvoiceId { get; set; }
    public Invoice? Invoice { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public string? PaymentReference { get; set; }


    public ICollection<PaymentLog>? PaymentLogs { get; set; }
}
