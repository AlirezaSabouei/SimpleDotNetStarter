using Project.Domain.Entities;

namespace Project.Domain.Events;

public class StudentCreatedEvent : BaseEvent
{
    public Student Student { get; set; }
}