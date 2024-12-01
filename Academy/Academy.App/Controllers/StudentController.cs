using Academy.Service.Services;


namespace Academy.App.Controllers
{
    internal class StudentController
    {
        private readonly StudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }
        public void Create()
        {

            _studentService.Create(new() { Name = "Rasim", Age = 20,GradeName=Core.Enums.PointName.B }, 1);
        }
        public void Update()
        {
            _studentService.Update(4,new() { Name = null, Age = 22, GradeName = Core.Enums.PointName.B }, 1);
        }
    }
}
