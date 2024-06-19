using Backend_Kasuta.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Kasuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersViewController : Controller
    {
        public static KasutaDbContext context = new KasutaDbContext();
        [HttpGet]
        [Route("get/{userId}")]
        public ActionResult<IEnumerable<OrdersView>> GetUserOrders(int userId)
        {
            try
            {
                var data = context.OrdersViews.Where(x => x.UserId ==  userId).ToList();
                return data;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
