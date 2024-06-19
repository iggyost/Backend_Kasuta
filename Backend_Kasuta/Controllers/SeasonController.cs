using Backend_Kasuta.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Kasuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonController : Controller
    {
        public static KasutaDbContext context = new KasutaDbContext();
        [HttpGet]
        [Route("view")]
        public ActionResult<IEnumerable<Season>> View()
        {
            try
            {
                var seasons = context.Seasons.ToList();
                return seasons;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
