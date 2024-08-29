using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class BankDetail : BaseEntity<Guid>
{
    public string? Name { get; set; }

    public int AccountNumber { get; set; }

    public int IBAN { get; set; }

    public int BIC { get; set; }

    public Guid PaymentId { get; set; }
    public Payment? Payment { get; set; }
}
