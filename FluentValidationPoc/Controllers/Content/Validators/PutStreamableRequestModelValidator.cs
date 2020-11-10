using FluentValidation;
using FluentValidationPoc.Controllers.Content.Models;

namespace FluentValidationPoc.Controllers.Content.Validators
{
    public class PutStreamableRequestModelValidator<T> : PutAssetRequestModelValidator<T>
        where T : PutStreamableRequestModel
    {
        public PutStreamableRequestModelValidator()
        {
            // Required
            RuleFor(x => x.AudioType).NotEmpty();
            RuleFor(x => x.FrameRate).NotEmpty();
            RuleFor(x => x.BitRate).NotNull();

            RuleFor(x => x.ContentFileSize).NotNull();
            RuleFor(x => x.ContentCheckSum).NotEmpty().Matches(@"^[a-fA-F0-9]{32}$");
            RuleFor(x => x.ContentPath).NotEmpty();

            // Optional
            RuleForEach(x => x.Languages).MaximumLength(20);
            RuleForEach(x => x.SubtitleLanguages).MaximumLength(20);
            RuleForEach(x => x.DubbedLanguages).MaximumLength(20);
        }
    }
}
