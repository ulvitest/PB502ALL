

using Academy.Core.Entities;
using Academy.DataAccess.Data;
using Academy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly AcademyContext _context;
        public StudentService()
        {
            _context = new AcademyContext();
        }
        public List<Student> GetAll() =>
            _context.Students
            .Include(s => s.Group)
            .ToList();
        public async Task<List<Student>> GetAllAsync() =>
          await _context.Students
           .Include(s => s.Group)
           .ToListAsync();
        public Student GetById(int? id)
        {
            if (id is null)
                throw new Exception("id is null");
            var existStudent = _context.Students
                .Include(s => s.Group)
                .SingleOrDefault(g => g.Id == id);
            if (existStudent is null)
                throw new Exception("student not found with id");
            return existStudent;
        }
        public async Task<Student> GetByIdAsync(int? id)
        {
            if (id is null)
                throw new Exception("id is null");
            var existStudent = await _context.Students
                 .Include(s => s.Group)
                .SingleOrDefaultAsync(g => g.Id == id);
            if (existStudent is null)
                throw new Exception("student not found with id");
            return existStudent;
        }
        public void DeleteById(int? id)
        {
            var existStudent = GetById(id);
            _context.Students.Remove(existStudent);
            _context.SaveChanges();
        }
        public async Task DeleteByIdAsync(int? id)
        {
            var existStudent = await GetByIdAsync(id);
            _context.Students.Remove(existStudent);
            await _context.SaveChangesAsync();
        }
        public void Update(int? id, Student student, int groupId)
        {
            var existStudent = GetById(id);
            var existGroup = _context.Groups
                .Include(g=>g.Students)
                .FirstOrDefault(g => g.Id == groupId);
            if (existGroup is null)
                throw new Exception("group not found with id..");

            if (existStudent.GroupId != groupId)
            {
                if (existGroup.Students.Count >= existGroup.Limit)
                    throw new Exception("group is full");
            }

            existStudent.GroupId = groupId;
            existStudent.Name = student.Name ?? existStudent.Name;
            existStudent.GradeName = student.GradeName;
            existStudent.Age=student.Age;
            _context.SaveChanges();
        }
        public async Task UpdateAsync(int? id, Student student, int groupId)
        {
            var existStudent = await GetByIdAsync(id);
            var existGroup = await _context.Groups.FirstOrDefaultAsync(g => g.Id == groupId);
            if (existGroup is null)
                throw new Exception("group not found with id..");

            if (existStudent.GroupId != groupId)
            {
                if (existGroup.Students.Count >= existGroup.Limit)
                    throw new Exception("group is full");
            }

            existStudent.GroupId = groupId;
            existStudent.Name = student.Name ?? existStudent.Name;
            existStudent.GradeName = student.GradeName;
            await _context.SaveChangesAsync();
        }
        public void Create(Student student, int groupId)
        {
            var existGroup = _context.Groups
                .Include(g=>g.Students)
                .FirstOrDefault(g => g.Id == groupId);
            if (existGroup is null)
                throw new Exception("group not found with id..");
            if (existGroup.Students.Count >= existGroup.Limit)
                throw new Exception("group is full");
             student.GroupId = groupId;
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public async Task CreateAsync(Student student, int groupId)
        {
            var existGroup = await _context.Groups.FirstOrDefaultAsync(g => g.Id == groupId);
            if (existGroup is null)
                throw new Exception("group not found with id..");
            if (existGroup.Students.Count >= existGroup.Limit)
                throw new Exception("group is full");

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }
        public List<Student> GetAllWithGroupId(int groupId) =>
          _context.Students
            .Where(s => s.GroupId == groupId)
          .Include(s => s.Group)
          .ToList();
        public async Task<List<Student>> GetAllWithGroupIdAsync(int groupId) =>
          await _context.Students
             .Where(s => s.GroupId == groupId)
           .Include(s => s.Group)
           .ToListAsync();

    }
}
