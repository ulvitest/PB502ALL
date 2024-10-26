namespace AbstractClassInterface.HomeWork.Models
{
    internal interface ILibrary
    {
        void AddBook(Book book);
        Book FindBookByName(string name);
        bool RemoveBookByName(string name);
        void SearchForBooks(string search);
        void ShowAll();
    }
}