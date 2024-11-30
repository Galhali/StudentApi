using StudentApi.Models;
using StudentApi.Repositories;

namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task AddStudentAsync(Student student)
        {
            await studentRepository.AddStudentAsync(student);
        }

        public async Task DeleteStudentAsync(Guid id)
        {
            await studentRepository.DeleteStudentAsync(id);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await studentRepository.GetAllStudentsAsync();
        }

        public async Task<Student?> GetStudentAsync(Guid id)
        {
            return await studentRepository.GetStudentByIdAsync(id);
        }

        public async Task UpdateStudentAsync(Student student)
        {
            await studentRepository.UpdateStudentAsync(student);
        }
    }
}
