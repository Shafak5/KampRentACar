using Entities.Concrete;
using FluentValidation;
using System;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.RentDate).GreaterThanOrEqualTo(DateTime.Today).WithMessage("Rent Date can't be earlier than today!!");
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate).WithMessage("Rent Date can't bigger than Return Date!!");
        }
    }
}