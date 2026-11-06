using Application.Responses;
using Domain.Models;

namespace Application.Interfaces;

public interface IAuthorService
{
    ApiResponse<bool> AddAuthor(Authors author);
    ApiResponse<bool> UpdateAuthor(Authors author);
    ApiResponse<bool> DeleteAuthor(int id);
    ApiResponse<Authors> GetAuthor(int id);
    ApiResponse<List<Authors>> GetAuthors();
}
