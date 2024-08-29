namespace Domain.Entities.BaseEntities;

public class BaseEntity<T> where T : struct
{
    public T Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = string.Empty;

    public DateTime UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = string.Empty;
}
