namespace TimeTracker.Entities;

using System.ComponentModel.DataAnnotations;

public class ProjectEntity
{
    [Key]
    public int Id { get; set; }

    public ClientEntity Client { get; set; } = default!;

    public string Name { get; set; } = "";

    public bool IsActive { get; set; }

    [MaxLength(10)]
    public string? Color { get; set; }
}
