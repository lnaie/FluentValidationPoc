using System;

namespace FluentValidationPoc.Controllers.Content.Models
{
    public class PutMovieAssetRequestModel : PutStreamableRequestModel
    {
        public bool? Encryption { get; set; }
        public string AnalogProtectionSystem { get; set; }
        public string CgmsA { get; set; }
    }
}
