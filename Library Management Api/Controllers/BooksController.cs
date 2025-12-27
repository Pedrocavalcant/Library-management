using Library_Management_Api.DTO;
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
        var result = _bookService._consultaLivro.BuscarLivros();
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(typeof(CriarLivroDto), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateBook([FromBody] CriarLivroDto dto)
    {
        var result = _bookService._criarLivro.AdicionarLivro(dto);
        return Created("", result);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateBook([FromQuery]int Id, [FromBody] ConsultaLivroDto dto)
    {
        var result = _bookService._atualizarLivro.AlterarLivro(dto);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(CriarLivroDto), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteBook([FromQuery]int Id)
    {
        var result = _bookService._deletarLivro.RemoverLivro(Id);
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(BookModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetBookByID([FromQuery] Guid Id)
    {
        var result = _bookService._consultaLivroId.BuscarLivro(Id);
        return Ok(result);
    }
}
