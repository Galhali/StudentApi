using StudentApi.Models;

namespace StudentApi.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(Guid id);
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(Guid id);
        Task UpdateStudentAsync(Student student);
    }
}
