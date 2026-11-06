using Domain.Models;

namespace Domain.Interfaces;

public interface IAuthorRepository
{
    bool AddAuthor(Authors author);
    bool UpdateAuthor(Authors author);
    bool DeleteAuthor(int id);
    Authors GetAuthor(int id);
    List<Authors> GetAuthors();
}
