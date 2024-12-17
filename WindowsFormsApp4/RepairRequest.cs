using System;

public class RepairRequest
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime RequestDate { get; set; }
    public bool IsCompleted { get; set; }
    public string Status { get; set; } // Новое поле для статуса заявки

    public RepairRequest(int id, string description, DateTime requestDate, bool isCompleted, string status)
    {
        Id = id;
        Description = description;
        RequestDate = requestDate;
        IsCompleted = isCompleted;
        Status = status;
    }
}
