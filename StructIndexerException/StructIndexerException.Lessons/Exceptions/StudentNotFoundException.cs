

namespace StructIndexerException.Lessons.Exceptions
{
    internal class StudentNotFoundException:Exception
    {
        public StudentNotFoundException(){}
        public StudentNotFoundException(string message):base(message) { }
        public StudentNotFoundException(string message,Exception inner):base(message,inner)
        {
            
        }
    }
}
