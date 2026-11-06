using Domain.Models;

namespace Domain.Interfaces;

public interface IBookRepository
{
    bool AddBook(Books book);
    bool UpdateBook(Books book);
    bool DeleteBook(int id);
    Books GetBook(int id);
    List<Books> GetBooks();
}
