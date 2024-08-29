using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class ShippingDetail : BaseEntity<Guid>
{
    public Guid InvoiceId { get; set; }
    public Invoice? Invoice { get; set; }

    public string? Address { get; set; }

    public DateTime Date { get; set; }

    public DateTime EstimatedErrival { get; set; }
}
