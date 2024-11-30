using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using StudentApi.Models;

namespace StudentApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task AddStudentAsync(Student student)
        {
            context.Students.Add(student);
            await context.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            var student = await context.Students.FindAsync(id);
            if(student != null)
            {
                context.Students.Remove(student);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await context.Students.ToListAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(Guid id)
        {
            return await context.Students.FindAsync(id);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
