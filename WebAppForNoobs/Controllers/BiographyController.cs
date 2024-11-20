using Microsoft.AspNetCore.Mvc;
using WebAppForNoobs.Common;

namespace WebAppForNoobs.Controllers
{
    [Route("api/biography")]
    [ApiController]
    public class BiographyController : ControllerBase
    {
        [HttpPost]
        [Route("add/{id}")]
        public IActionResult AddBiography(int id, [FromBody] string biographyData)
        {
            var author = DatabaseDemo.Authors.FirstOrDefault(x => x.Id == id);

            if (author is null)
                return NotFound();

            author.ModifyBiography(biographyData);

            return Ok();
        }
    }
}