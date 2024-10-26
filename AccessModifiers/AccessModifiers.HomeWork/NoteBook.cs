

namespace AccessModifiers.HomeWork
{
    internal class NoteBook:Product
    {
        public int Storage;
        public NoteBook(string name,double price,int storage):base(name,price) 
        {
            Storage = storage;
        }
    }
}
