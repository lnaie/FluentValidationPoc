using FluentValidation;
using FluentValidationPoc.Controllers.Content.Models;

namespace FluentValidationPoc.Controllers.Content.Validators
{
    public class PutAssetRequestModelValidator<T> : AbstractValidator<T>
        where T : PutAssetRequestModel
    {
        public PutAssetRequestModelValidator()
        {
            RuleFor(x => x.Provider).NotEmpty();
            RuleFor(x => x.VersionMajor).NotNull();
            RuleFor(x => x.VersionMinor).NotNull();
            RuleFor(x => x.CreationDate).NotNull();
            RuleFor(x => x.ProviderId).NotEmpty().Matches(@"^([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,}$").MaximumLength(20);
            RuleFor(x => x.AssetId).NotEmpty();
        }
    }
}
