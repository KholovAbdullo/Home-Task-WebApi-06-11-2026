using Application.Responses;
using Domain.Models;

namespace Application.Interfaces;

public interface IBookService
{
    ApiResponse<bool> AddBook(Books book);
    ApiResponse<bool> UpdateBook(Books book);
    ApiResponse<bool> DeleteBook(int id);
    ApiResponse<Books> GetBook(int id);
    ApiResponse<List<Books>> GetBooks();
}
