using System.Net;
using Application.Interfaces;
using Application.Responses;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Service;

public class AuthorService(IAuthorRepository authorRepository) : IAuthorService
{
    private IAuthorRepository authorRepository1 = authorRepository;
    public ApiResponse<bool> AddAuthor(Authors author)
    {
        var res = authorRepository1.AddAuthor(author);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added!", res);
    }

    public ApiResponse<bool> DeleteAuthor(int id)
    {
         var res = authorRepository1.DeleteAuthor(id);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added!", res);
    }

    public ApiResponse<Authors> GetAuthor(int id)
    {
        var res = authorRepository1.GetAuthor(id);
        return new ApiResponse<Authors>(HttpStatusCode.OK, "Book id.",res);
    }

    public ApiResponse<List<Authors>> GetAuthors()
    {
        var res = authorRepository1.GetAuthors();
        return new ApiResponse<List<Authors>>(HttpStatusCode.OK, "List of books!", res);
    }

    public ApiResponse<bool> UpdateAuthor(Authors author)
    {
        var res = authorRepository1.UpdateAuthor(author);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not updated!", res);
    }

}
