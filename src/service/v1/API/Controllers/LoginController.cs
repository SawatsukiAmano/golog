using Microsoft.AspNetCore.Http;
using ModelRes;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet]
        public string GetTest()
        {
            return "连接成功" + DateTime.Now;
        }


        [HttpGet]
        public result GetAcc(string acc)
        {
            result res = new result();

            res.message = "123";

            return res;
        }

    }
}
