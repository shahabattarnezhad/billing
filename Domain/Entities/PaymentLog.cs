using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class PaymentLog : BaseEntity<Guid>
{
    public DateTime TimeStamp { get; set; }

    public string? LogMessage { get; set; }

    public Guid PaymentId { get; set; }
    public Payment? Payment { get; set; }
}
