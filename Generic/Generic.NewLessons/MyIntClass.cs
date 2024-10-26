

namespace Generic.NewLessons
{
    internal class MyClass<T> 
        //where T : class, IComparable, new()
        //where T : class
        //where T : struct
        //where T : new()
         //where T : IComparable<T>
         //where T : A
        //where T : U
    {
        public T[] array;
        public MyClass()
        {
            array= new T[0];
        }

        public void AddItem(T value)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = value;
        }
        public void GetAll()
        {
            foreach(T item in array)
                Console.WriteLine(item);
        }
    }
  
   
}
