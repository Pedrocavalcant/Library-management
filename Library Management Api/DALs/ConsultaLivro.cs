using Library_Management_Api.DTO;

namespace Library_Management_Api.DALs;

public class ConsultaLivro
{
    public static List<ConsultaLivroDto> Livros = new()
    {
        new ConsultaLivroDto
        {
            Title = "Dom Casmurro",
            Author = "Machado de Assis",
            Genre = "Romance",
            Price = 45.90,
            Stock = 12
        },
        new ConsultaLivroDto
        {
            Title = "1984",
            Author = "George Orwell",
            Genre = "Ficção Científica",
            Price = 59.90,
            Stock = 10

        }
    };
    public async Task<List<ConsultaLivroDto>> BuscarLivros()
    {

        return Livros;
    }
}
