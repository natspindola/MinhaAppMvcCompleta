using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(expression: f => f.Nome)
            .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
            .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caractéres.");

            When(predicate: f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, action: () =>
            {
                //RuleFor(expression:f =>f.Documento.Length)
            });

            When(predicate: f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, action: () =>
            {
                
            });
        }
        
    }
}
