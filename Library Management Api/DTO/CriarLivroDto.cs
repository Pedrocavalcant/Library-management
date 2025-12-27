namespace Library_Management_Api.DTO;

public class CriarLivroDto : ConsultaLivroDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
