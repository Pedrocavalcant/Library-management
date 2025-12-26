using Library_Management_Api.Models;
using Library_Management_Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;

    public BooksController(BookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(BookModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetAll()
    {
        var result = await _bookService._consultaLivro.BuscarLivros();
        return Ok(result);
    }
}
