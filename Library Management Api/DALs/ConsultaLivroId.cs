using Library_Management_Api.DTO;

namespace Library_Management_Api.DALs;

public class ConsultaLivroId
{
    public static List<CriarLivroDto> Livros = new()
    {
        new CriarLivroDto
        {
            Title = "Dom Casmurro",
            Author = "Machado de Assis",
            Genre = "Romance",
            Price = 45.90,
            Stock = 12
        },
        new CriarLivroDto
        {
            Title = "1984",
            Author = "George Orwell",
            Genre = "Ficção Científica",
            Price = 59.90,
            Stock = 10
        }
    };
    public async Task<CriarLivroDto> BuscarLivro(Guid id)
    {
        var livro = new CriarLivroDto();
        return livro;
    }
}
