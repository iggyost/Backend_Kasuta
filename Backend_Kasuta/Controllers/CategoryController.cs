using Backend_Kasuta.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Kasuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        public static KasutaDbContext context = new KasutaDbContext();
        [HttpGet]
        [Route("view")]
        public ActionResult<IEnumerable<Category>> View()
        {
            try
            {
                var categories = context.Categories.ToList();
                return categories;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}