using FluentValidation;
using MVCCoreEcommerce.DtoLayer.Dto.CategoryDto;

namespace MVCCoreEcommerce.BusinessLayer.Validator.Category
{
    public class CategoryValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adını Boş Geçmeyiniz");
        }
    }
}
