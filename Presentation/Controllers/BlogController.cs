using BusinessLogic;
using DataAccess;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace UI.Controllers
{
    [Route("api/blog")]
    [Produces("application/json")]
    public class BlogController : Controller
    {
        private readonly BlogContext _blogContext;

        public BlogController(IConfiguration config) => _blogContext = new BlogContext(config["Data:Blog:ConnectionString"]);
        public IActionResult Index()
        {
            var blog = _blogContext.Blogs.First();
            return View(blog);
        }

    }
}