using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController(IAuthorService authorService) : ControllerBase
{
    private IAuthorService authorService1 = authorService;

    [HttpGet]
    public ApiResponse<List<Authors>> GetAuhtor()
    {
        return authorService1.GetAuthors();
    }

    [HttpGet("{id:int}")]
    public ApiResponse<Authors> GetAuhtor(int id)
    {
        return authorService1.GetAuthor(id);
    }

    [HttpPost]
    public ApiResponse<bool> AddAuthor(Authors authors)
    {
        return authorService1.AddAuthor(authors);
    }

    [HttpDelete]
    public ApiResponse<bool> DeleteAuthor(int id)
    {
        return authorService1.DeleteAuthor(id);
    }

    [HttpPut]
    public ApiResponse<bool> UpdateAuthor(Authors authors)
    {
        return authorService1.UpdateAuthor(authors);
    }
}
