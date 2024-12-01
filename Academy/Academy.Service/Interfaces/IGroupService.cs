using Academy.Core.Entities;

namespace Academy.Service.Interfaces
{
    public interface IGroupService
    {
        void Create(Group group);
        Task CreateAsync(Group group);
        void DeleteById(int? id);
        Task DeleteByIdAsync(int? id);
        List<Group> GetAll();
        Task<List<Group>> GetAllAsync();
        List<Group> GetAllWithNo(string value);
        Task<List<Group>> GetAllWithNoAsync(string value);
        Group GetById(int? id);
        Task<Group> GetByIdAsync(int? id);
        void Update(int? id, Group group);
        Task UpdateAsync(int? id, Group group);
    }
}