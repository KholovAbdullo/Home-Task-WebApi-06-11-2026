using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController(IBookService bookService) : ControllerBase
{
    private IBookService bookService1 = bookService;

    [HttpGet]
    public ApiResponse<List<Books>> GetBooks()
    {
        return bookService1.GetBooks();
    }

    [HttpGet("{id:int}")]
    public ApiResponse<Books> GetBook(int id)
    {
        return bookService1.GetBook(id);
    }

    [HttpPost]
    public ApiResponse<bool> AddBook(Books books)
    {
        return bookService1.AddBook(books);
    }

    [HttpDelete]
    public ApiResponse<bool> DeleteBook(int id)
    {
        return bookService1.DeleteBook(id);
    }

    [HttpPut]
    public ApiResponse<bool> UpdateBook(Books books)
    {
        return bookService1.UpdateBook(books);
    }
}
