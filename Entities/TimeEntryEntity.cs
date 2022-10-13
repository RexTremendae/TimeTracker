namespace TimeTracker.Entities;

using System.ComponentModel.DataAnnotations;

public class TimeEntryEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Comment { get; set; }

    public ProjectEntity Project { get; set; } = default!;

    public bool IsReported { get; set; }
}
