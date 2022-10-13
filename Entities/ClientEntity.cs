namespace TimeTracker.Entities;

using System.ComponentModel.DataAnnotations;

public class ClientEntity
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = "";
}
