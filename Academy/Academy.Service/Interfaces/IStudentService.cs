using Academy.Core.Entities;

namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student, int groupId);
        Task CreateAsync(Student student, int groupId);
        void DeleteById(int? id);
        Task DeleteByIdAsync(int? id);
        List<Student> GetAll();
        Task<List<Student>> GetAllAsync();
        Student GetById(int? id);
        Task<Student> GetByIdAsync(int? id);
        void Update(int? id, Student student, int groupId);
        Task UpdateAsync(int? id, Student student, int groupId);
        Task<List<Student>> GetAllWithGroupIdAsync(int groupId);
        List<Student> GetAllWithGroupId(int groupId);
    }
}