

namespace Generic.NewLessons.Models
{
    internal class Worker
    {
        public Worker(int ıd, string name, double salary)
        {
            Id = ıd;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static List<Worker> GetAll()
        {
            Worker worker1 = new Worker(1,"Samir",salary:5000);
            Worker worker2 = new Worker(2,"Aysun",salary:3000);
            Worker worker3 = new Worker(3,"Ali",salary:1000);
            Worker worker4 = new Worker(4,"Senan",salary:500);
            List<Worker> workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
            return workers;
        }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }

        public static Worker FindById(int id)
        {
            var existWorker=Worker.GetAll().Find(x => x.Id == id);
            if (existWorker != null)
                return existWorker;
            return null;

        }
        public static List<Worker> FindByName(string name) =>
            Worker.GetAll().FindAll(x => x.Name.ToLower().Contains(name.ToLower()));
        
    }
}
