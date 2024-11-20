using Microsoft.AspNetCore.Mvc;
using WebAppForNoobs.Common;

namespace WebAppForNoobs.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpPost]
        [Route("add")]
        public IActionResult AddAuthor([FromBody] string authorName)
        {
            var authorId = DatabaseDemo.Authors.Count + 1;
            var newAuthor = new Author(authorId, authorName);

            DatabaseDemo.Authors.Add(newAuthor);

            return Ok();
        }

        [HttpGet]
        public List<Author> GetAll() => DatabaseDemo.Authors;
    }
}