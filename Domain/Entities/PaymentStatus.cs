﻿using Domain.Entities.BaseEntities;

namespace Domain.Entities;

public class PaymentStatus : BaseEntity<Guid>
{
    public string? Name { get; set; }

    public string? Description { get; set; }


    public ICollection<Payment>? Payments { get; set; }
}