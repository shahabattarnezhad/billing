using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class Taxrate : BaseEntity<Guid>
{
    public string? Title { get; set; }

    public decimal Rate { get; set; }


    public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
}
