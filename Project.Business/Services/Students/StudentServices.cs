using Microsoft.EntityFrameworkCore;
using Project.Business.Common.Data;
using Project.Domain.Entities;
using Project.Domain.Events;

namespace Project.Business.Services.Students;

public class StudentServices(Context context)
{
    public async Task<Student> CreateStudent(Student student)
    {
        student.AddDomainEvent(new StudentCreatedEvent()
        {
            Student = student
        });
        context.Students.Add(student);
        await context.SaveChangesAsync();
        return student;
    }
    
    public async Task<List<Student>> GetAllStudents()
    {
        return await context.Students.ToListAsync();
    }
    // TODO: Add service methods
}
