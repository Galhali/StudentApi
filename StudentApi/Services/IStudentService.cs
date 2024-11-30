using StudentApi.Models;

namespace StudentApi.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student?> GetStudentAsync(Guid id);
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(Guid id);
        Task UpdateStudentAsync(Student student);
    }
}
