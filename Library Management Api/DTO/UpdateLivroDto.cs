namespace Library_Management_Api.DTO;

public class UpdateLivroDto : ConsultaLivroDto
{
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
