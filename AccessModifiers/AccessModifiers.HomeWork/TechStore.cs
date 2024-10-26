

namespace AccessModifiers.HomeWork
{
    internal class TechStore
    {
        //fields
        public string Name;
        public NoteBook[] NoteBooks;

        //method
        public TechStore(int size,string name)
        {
            NoteBooks = new NoteBook[size]; //0
            Name = name;
        }

        public void Add(NoteBook newNoteBook) //2 
        {
            //
            Array.Resize(ref NoteBooks, NoteBooks.Length+1);
            NoteBooks[NoteBooks.Length-1] = newNoteBook;
            Console.WriteLine(newNoteBook.Name +" "+"elave edildi...");
        }
        public bool Find(string name)
        {
            bool result = false;
            foreach (var noteBook in NoteBooks)
            {
                if (name.Equals(noteBook.Name,StringComparison.OrdinalIgnoreCase))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void ShowAll()
        {
            foreach (var item in NoteBooks)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
