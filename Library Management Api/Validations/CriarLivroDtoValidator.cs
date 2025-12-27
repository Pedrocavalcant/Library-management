using FluentValidation;
using Library_Management_Api.DTO;

namespace Library_Management_Api.Validations;

public class CriarLivroDtoValidator : AbstractValidator<CriarLivroDto>
{
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
    public CriarLivroDtoValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .Length(2, 120)
            .WithMessage("Deve ter entre 2 e 120 caracteres.");

        RuleFor(x => x.Author)
            .NotEmpty()
            .Length(2, 120)
            .WithMessage("Deve ter entre 2 e 120 caracteres.");

        RuleFor(x => x.Price)
            .GreaterThanOrEqualTo(0)
            .WithMessage("O preco deve ser maior ou igual a zero.");

        RuleFor(x => x.Stock)
            .GreaterThanOrEqualTo(0)
            .WithMessage("O preco deve ser maior ou igual a zero.");

        RuleFor(x => x.Genre)
            .NotEmpty()
            .Must(g => GenerosValidos.Contains(g))
            .WithMessage("Genero invalido");
    }
}
