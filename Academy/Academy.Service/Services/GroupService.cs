

using Academy.Core.Entities;
using Academy.DataAccess.Data;
using Academy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly AcademyContext _context;
        public GroupService()
        {
            _context = new AcademyContext();
        }
        public void Create(Group group)
        {
            if (_context.Groups.Any(g => g.No == group.No))
                throw new Exception("already exist with name");
            _context.Groups.Add(group);
            _context.SaveChanges();
        }
        public async Task CreateAsync(Group group)
        {
            if (await _context.Groups.AnyAsync(g => g.No == group.No))
                throw new Exception("already exist with name");
            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();
        }
        public List<Group> GetAll() => _context.Groups
             .Include(g => g.Students)
            .ToList();
        public List<Group> GetAllWithNo(string value) => _context.Groups
             .Include(g => g.Students)
            .Where(g => g.No.Contains(value))
            .ToList();
        public async Task<List<Group>> GetAllWithNoAsync(string value) => await _context.Groups
         .Include(g => g.Students)
            .Where(g => g.No.Contains(value))
         .ToListAsync();

        public async Task<List<Group>> GetAllAsync() => await _context.Groups
             .Include(g => g.Students)
            .ToListAsync();

        public Group GetById(int? id)
        {
            if (id is null)
                throw new Exception("id is null");
            var existGroup = _context.Groups
                .Include(g=>g.Students)
                .SingleOrDefault(g => g.Id == id);
            if (existGroup is null)
                throw new Exception("group not found with id");
            return existGroup;
        }
        public async Task<Group> GetByIdAsync(int? id)
        {
            if (id is null)
                throw new Exception("id is null");
            var existGroup = await _context.Groups
                 .Include(g => g.Students)
                .SingleOrDefaultAsync(g => g.Id == id);
            if (existGroup is null)
                throw new Exception("group not found with id");
            return existGroup;
        }
        public void DeleteById(int? id)
        {
            var existGroup = GetById(id);
            _context.Groups.Remove(existGroup);
            _context.SaveChanges();
        }
        public async Task DeleteByIdAsync(int? id)
        {
            var existGroup = await GetByIdAsync(id);
            _context.Groups.Remove(existGroup);
            await _context.SaveChangesAsync();
        }
        public void Update(int? id, Group group)
        {
            var existGroup = GetById(id);
            existGroup.No = group.No ?? existGroup.No;
            existGroup.Limit = group.Limit;
            _context.SaveChanges();
        }
        public async Task UpdateAsync(int? id, Group group)
        {
            var existGroup = await GetByIdAsync(id);
            if (_context.Groups.Any(g => g.No == group.No&&g.Id!=id))
                throw new Exception("already exist with name");
            existGroup.No = group.No ?? existGroup.No;
            existGroup.Limit = group.Limit;
            await _context.SaveChangesAsync();
        }

    }
}
