using Microsoft.EntityFrameworkCore;
using Project.Business.Common.Data;
using Project.Domain.Entities;

namespace Project.Business.Services.Students;

public class StudentServices(Context context)
{
    public async Task<List<Student>> GetAllStudents()
    {
        return await context.Students.ToListAsync();
    }
    // TODO: Add service methods
}
