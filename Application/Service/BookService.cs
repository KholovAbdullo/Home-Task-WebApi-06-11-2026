using System.Net;
using Application.Interfaces;
using Application.Responses;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Service;

public class BookService(IBookRepository bookRepository) : IBookService
{
    private IBookRepository bookRepository1 = bookRepository;
    public ApiResponse<bool> AddBook(Books book)
    {
        var res = bookRepository1.AddBook(book);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added!", res);
    }

    public ApiResponse<bool> DeleteBook(int id)
    {
        var res = bookRepository1.DeleteBook(id);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added!", res);
    }

    public ApiResponse<Books> GetBook(int id)
    {
        var res = bookRepository1.GetBook(id);
        return new ApiResponse<Books>(HttpStatusCode.OK, "Book id.", res);
    }

    public ApiResponse<List<Books>> GetBooks()
    {
        var res = bookRepository1.GetBooks();
        return new ApiResponse<List<Books>>(HttpStatusCode.OK, "List of books!", res);
    }

    public ApiResponse<bool> UpdateBook(Books book)
    {
        var res = bookRepository1.UpdateBook(book);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not updated!", res);
    }

}
