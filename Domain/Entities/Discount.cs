using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class Discount : BaseEntity<Guid>
{
    public string? Title { get; set; }

    public decimal Value { get; set; }


    public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
}
