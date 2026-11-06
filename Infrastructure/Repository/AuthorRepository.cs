using Dapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repository;

public class AuthorRepository(Database database) : IAuthorRepository
{
    private Database database1 = database;
    public bool AddAuthor(Authors author)
    {
        using var conn=database1.Connection();
        conn.Open();
        var query="insert into Author(fullname,country,birthyear) values(@fullname,@country,@birthyear)";
        var res = conn.Execute(query,new{author.Fullname,author.Country,author.Birthyear});
        return res > 0;
    }

    public bool DeleteAuthor(int id)
    {
        using var conn=database1.Connection();
        conn.Open();
        var query="delete from Author where id=@id";
        var res = conn.Execute(query,new{id});
        return res > 0;
    }

    public Authors GetAuthor(int id)
    {
        using var conn=database1.Connection();
        conn.Open();
        var query="select * from Author where id=@id";
        var author= conn.QuerySingle<Authors>(query,new{id});
        return author;
    }

    public List<Authors> GetAuthors()
    {
        using var conn=database1.Connection();
        conn.Open();
        var query= conn.Query<Authors>("select * from Author");
        return query.ToList();
    }

    public bool UpdateAuthor(Authors author)
    {
        using var conn=database1.Connection();
        conn.Open();
        var query="update Author set fullname=@fullname,country=@country,birthyear=@birthyear where id=@id";
        var res = conn.Execute(query,author);
        return res > 0;
    }

}
