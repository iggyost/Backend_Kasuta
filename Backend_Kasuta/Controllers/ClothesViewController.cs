using Backend_Kasuta.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Kasuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesViewController : Controller
    {
        public static KasutaDbContext context = new KasutaDbContext();
        [HttpGet]
        [Route("get")]
        public ActionResult<IEnumerable<ClothesView>> GetClothes()
        {
            try
            {
                var data = context.ClothesViews.ToList();
                return data;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
