using FluentValidation;
using FluentValidationPoc.Controllers.Content.Models;

namespace FluentValidationPoc.Controllers.Content.Validators
{
    public class ReleaseRequestModelValidator : AbstractValidator<ReleaseRequestModel>
    {
        public ReleaseRequestModelValidator()
        {
            // Required
            RuleFor(x => x.ProviderId).NotEmpty();
            RuleFor(x => x.ReleaseAssetId).NotEmpty();
        }
    }
}
