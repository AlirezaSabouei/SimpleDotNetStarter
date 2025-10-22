using MediatR;
using Project.Domain.Events;

namespace Project.Business.EventHandlers;

public class StudentCreatedEventHandler : INotificationHandler<StudentCreatedEvent>
{
    public Task Handle(StudentCreatedEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine(notification.Student.Id);
        //Do something
        return Task.CompletedTask;
    }
}