using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAppStateManagment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "Category 1", "Category 2", "Category 3", "Category 4", "Category 5" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] string category)
        {
            List<string> categories = new List<string> { "Category 1", "Category 2", "Category 3", "Category 4", "Category 5" };
            categories.Add(category);

            return Ok(categories.ToArray());
        }
    }
}
