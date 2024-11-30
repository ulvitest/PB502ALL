

namespace OrmPractice.Lesson.Entities
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; }
        public override string ToString()
        {
            return Id + " " + Name + " " + Limit;
        }
    }
}
