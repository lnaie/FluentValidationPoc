using System;

namespace FluentValidationPoc.Controllers.Content.Models
{
    public class PutAssetRequestModel
    {
        public string AssetId { get; set; }
        public string ProviderId { get; set; }
        public string Provider { get; set; }
        public int? VersionMajor { get; set; }
        public int? VersionMinor { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
