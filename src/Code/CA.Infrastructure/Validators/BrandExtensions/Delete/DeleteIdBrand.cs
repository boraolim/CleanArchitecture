﻿using FluentValidation;

using CA.Core.DTO;
using CA.Infrastructure.Extensions.Base;

namespace CA.Infrastructure.Validators
{
  public class DeleteIdBrand : AbstractValidator<DeleteBrandDTO>
  {
    public DeleteIdBrand()
    {
      RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                        .Must(u => u >= 0).WithMessage("El identificador de la marca del artículo no puede ser negativo.")
                        .Must(u => RegexExtensions.VerifyValue(u, @"^[0-9]+\z")).WithMessage("Formato de número entero incorrecto: solo dígitos.");
    }
  }
}
