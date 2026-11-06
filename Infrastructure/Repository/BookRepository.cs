using Dapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class BookRepository(Database database) : IBookRepository
{
    private Database database1 = database;
    public bool AddBook(Books book)
    {
        using var Connection=database1.Connection();
        Connection.Open();
        var query = @"insert into Books(title, publishedyear, totalcopies, author_id, genre_id) values(@Title, @Publishedyear, @Totalcopies, @authorId, @genreId)";
        var res = Connection.Execute(query, new{book.Title,book.Publishedyear,book.Totalcopies,book.authorId,book.genreId});
        return res > 0;
    }

    public bool DeleteBook(int id)
    {
        using var Connection=database1.Connection();
        Connection.Open();
        var query="delete from Books where id=@id";
        var res = Connection.Execute(query,new{id});
        return res > 0;
    }

    public Books GetBook(int id)
    {
        using var Connection=database1.Connection();
       Connection.Open();
       var query="select * from Books where id=@id";
       var book = Connection.QuerySingle<Books>(query,new{id});
       return book;
    }

    public List<Books> GetBooks()
    {
        using var Connection=database1.Connection();
        Connection.Open();
        var query = Connection.Query<Books>("select * from Books");
        return query.ToList();
    }

    public bool UpdateBook(Books book)
    {
        using var Connection=database1.Connection();
        Connection.Open();
        var query="update Books set title=@title, publishedyear=@publishedyear,totalcopies=@totalcopies,author_id=@author_id,genre_id=@genre_id where id=@id";
        var res = Connection.Execute(query,book);
        return res > 0;
    }

}
