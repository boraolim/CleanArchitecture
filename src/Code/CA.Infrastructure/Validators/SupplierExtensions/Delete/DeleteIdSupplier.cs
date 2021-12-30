﻿using FluentValidation;

using CA.Core.DTO;
using CA.Infrastructure.Extensions.Base;

namespace CA.Infrastructure.Validators
{
  public class DeleteIdSupplier : AbstractValidator<DeleteSupplierDTO>
  {
    public DeleteIdSupplier()
    {
      RuleFor(u => u.Id).Cascade(CascadeMode.Stop)
                        .Must(u => u >= 0).WithMessage("El identificador del proveedor no puede ser negativo.")
                        .Must(u => RegexExtensions.VerifyValue(u, @"^[0-9]+\z")).WithMessage("Formato de número entero incorrecto: solo dígitos.");
    }
  }
}
