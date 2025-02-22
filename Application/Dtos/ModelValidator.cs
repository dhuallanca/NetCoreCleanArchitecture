using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ModelValidator: AbstractValidator<ModelDto>
    {
        public ModelValidator() { 
            RuleFor(v=> v.MyProperty).NotNull().NotEmpty().WithMessage("Shouldn't be null");
        }
    }
}
