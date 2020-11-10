﻿using FluentValidation;
using FluentValidationPoc.Controllers.Content.Models;

namespace FluentValidationPoc.Controllers.Content.Validators
{
    public class PutMovieAssetRequestModelValidator<T> : PutStreamableRequestModelValidator<PutMovieAssetRequestModel>
    {
        public PutMovieAssetRequestModelValidator()
        {
            RuleFor(x => x.AnalogProtectionSystem).NotNull();
            RuleFor(x => x.CgmsA).NotNull();
        }
    }
}
