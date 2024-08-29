using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class Customer : BaseEntity<Guid>
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }


    public ICollection<Invoice>? Invoices { get; set; }
}