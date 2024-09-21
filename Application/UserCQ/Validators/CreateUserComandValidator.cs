using Application.UserCQ.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserCQ.Validators
{
    public class CreateUserComandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserComandValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O campo não pode ser vazio.")
                .EmailAddress().WithMessage("O campo 'email' não é válido.").WithErrorCode("400");
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("O campo 'username' não pode estar vazio");
        }
    }
}
