using Backend_Kasuta.ApplicationData;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Kasuta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        public static KasutaDbContext context = new KasutaDbContext();

        [HttpGet]
        [Route("enter/{email}/{password}")]
        public ActionResult<IEnumerable<User>> Enter(string email, string password)
        {
            try
            {
                var user = context.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
                if (user != null)
                {
                    return Ok(user);
                }
                else
                {
                    return BadRequest("Неверный пароль!");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
        [HttpGet]
        [Route("reg/{name}/{email}/{password}/{phone}")]
        public ActionResult<IEnumerable<User>> RegUser(string name, string email, string password, string phone)
        {
            try
            {
                var checkAvail = context.Users.Where(x => x.Email == email && x.Phone == phone).FirstOrDefault();
                if (checkAvail == null)
                {
                    User user = new User()
                    {
                        Phone = phone,
                        Password = password,
                        Email = email,
                        Name = name,
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    return Ok(user);
                }
                else
                {
                    return BadRequest("Пользователь с таким номером уже есть");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Ошибка сервера");
            }
        }
    }
}
