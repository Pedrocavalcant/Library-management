using Library_Management_Api.DTO;

namespace Library_Management_Api.DALs;

public class CriarLivro
{
    private static readonly List<CriarLivroDto> Livros = new();

    private static readonly string[] GenerosValidos =
    {
        "Romance",
        "Fantasia",
        "Ficção Científica",
        "Terror",
        "Suspense",
        "Biografia",
        "História",
        "Autoajuda",
        "Tecnologia"
    };
    public async Task<CriarLivroDto> AdicionarLivro(CriarLivroDto dto)
    {
        var existeLivro = Livros.Any(l =>
            l.Title.Equals(dto.Title, StringComparison.OrdinalIgnoreCase) ||
            l.Author.Equals(dto.Author, StringComparison.OrdinalIgnoreCase)
        );

        if(existeLivro)
        {
            throw new Exception("Titulo ou Autor ja existem");
        }

        if(dto.Stock < 0 || dto.Price < 0)
        {
            throw new Exception("Estoque ou Preco nao pode ser negativo");
        }

        if (!GenerosValidos.Contains(dto.Genre))
        {
            throw new Exception("Genero invalido");
        }

        return dto;
    }
}
