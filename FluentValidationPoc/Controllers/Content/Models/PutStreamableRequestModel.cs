using System;
using System.Collections.Generic;

namespace FluentValidationPoc.Controllers.Content.Models
{
    public class PutStreamableRequestModel : PutAssetRequestModel
    {
        public List<string> AudioType { get; set; }
        public string Resolution { get; set; }
        public int? FrameRate { get; set; }
        public string Codec { get; set; }
        public decimal? BitRate { get; set; }
        public string ScreenFormat { get; set; }
        public List<string> Languages { get; set; }
        public List<string> SubtitleLanguages { get; set; }
        public List<string> DubbedLanguages { get; set; }

        public string ContentPath { get; set; }
        public ulong? ContentFileSize { get; set; }
        public string ContentCheckSum { get; set; }
    }
}
