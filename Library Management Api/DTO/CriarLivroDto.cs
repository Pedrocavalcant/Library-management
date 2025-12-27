namespace Library_Management_Api.DTO;

public class CriarLivroDto : ConsultaLivroDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
}
