using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class InvoiceDetail : BaseEntity<Guid>
{
    public Guid InvoiceId { get; set; }
    public Invoice? Invoice { get; set; }

    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public Guid DiscountId { get; set; }
    public Discount? Discount { get; set; }

    public Guid TaxId { get; set; }
    public Taxrate? Taxrate { get; set; }

    public int Quantity { get; set; }

    public decimal LineTotal { get; set; }
}
