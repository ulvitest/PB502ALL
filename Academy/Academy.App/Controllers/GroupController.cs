

using Academy.Service.Services;

namespace Academy.App.Controllers
{
    internal class GroupController
    {
        private readonly GroupService _groupService;
        public GroupController()
        {
            _groupService = new GroupService();
        }
        public void Create()
        {
            _groupService.Create(new() { CreatedDate = DateTime.Now,No="Pb502",Limit=20 });
        }
        public async Task CreateAsync()
        {
           await _groupService.CreateAsync(new() { CreatedDate = DateTime.Now, No = "Pb503", Limit = 20 });
        }
        public void GetAll()
        {
            foreach (var group in _groupService.GetAll())
                Console.WriteLine(group);
        }
        public void GetAllWithNo()
        {
            string value = "1";
            foreach (var group in _groupService.GetAllWithNo(value))
                Console.WriteLine(group);
        }
    }
}
