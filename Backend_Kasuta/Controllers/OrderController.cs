using Backend_Kasuta.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Kasuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public static KasutaDbContext context = new KasutaDbContext();
        [HttpGet]
        [Route("create/{clothId}/{userId}")]
        public ActionResult<IEnumerable<Order>> CreateOrder(int clothId, int userId)
        {
            try
            {
                Order order = new Order()
                {
                    OrderNumber = $"Заказ {DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Minute}{DateTime.Now.Second}",
                    ClothId = clothId,
                    UserId = userId,
                    DeliveryPointId = 1,
                    OrderDate = DateTime.Now,
                    StatusId = 1,
                };
                context.Orders.Add(order);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
        [HttpGet]
        [Route("get/{userId}")]
        public ActionResult<IEnumerable<Order>> GetOrders(int userId)
        {
            try
            {
                var data = context.Orders.Where(x => x.UserId ==  userId).ToList();
                return data;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
