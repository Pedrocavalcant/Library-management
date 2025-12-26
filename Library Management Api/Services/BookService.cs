using Library_Management_Api.DALs;

namespace Library_Management_Api.Services;

public class BookService(ConsultaLivro _ConsultaLivro, CriarLivro _CriarLivro, AtualizarLivro _AtualizarLivro, DeletarLivro _DeletarLivro, ConsultaLivroId _ConsultaLivroId)
{
    public readonly ConsultaLivro _consultaLivro = _ConsultaLivro;
    public readonly CriarLivro _criarLivro = _CriarLivro;
    public readonly AtualizarLivro _atualizarLivro = _AtualizarLivro;
    public readonly DeletarLivro _deletarLivro = _DeletarLivro;
    public readonly ConsultaLivroId _consultaLivroId = _ConsultaLivroId;
}
