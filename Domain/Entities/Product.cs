using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class Product : BaseEntity<Guid>
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }


    public ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
}
