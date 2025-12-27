using Library_Management_Api.DTO;

namespace Library_Management_Api.DALs;

public class ConsultaLivroId
{
    public async Task<CriarLivroDto> BuscarLivro(Guid id)
    {
        var livro = new CriarLivroDto();
        return livro;
    }
}
