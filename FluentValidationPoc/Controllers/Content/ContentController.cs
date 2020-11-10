using FluentValidationPoc.Controllers.Content.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace FluentValidationPoc.Controllers.Content
{
    [Produces("application/json")]
    [Route("api/content/import")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        [HttpPut("{providerId}/{releaseAssetId}/movies")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [ProducesResponseType(503)]
        public ActionResult PutMovieAsset([FromRoute] ReleaseRequestModel routeModel,
            [FromBody] PutMovieAssetRequestModel model, CancellationToken cancellationToken)
        {
            return NoContent();
        }
    }
}
