using Library_Management_Api.DTO;

namespace Library_Management_Api.DALs;

public class AtualizarLivro
{
    public async Task<bool> AlterarLivro(UpdateLivroDto dto)
    {
        await Task.CompletedTask;
        return true;
    }
}
