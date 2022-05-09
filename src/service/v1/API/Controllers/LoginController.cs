using Microsoft.AspNetCore.Http;
using ModelRes;
using Microsoft.AspNetCore.Mvc;
using Model;
using IBLL;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IBLLUser _iBLLUser;
        public LoginController(IBLLUser bLLUser)
        {
            _iBLLUser = bLLUser;
        }

        [HttpGet]
        public string GetTest()
        {
            return "连接成功" + DateTime.Now;
        }


        [HttpGet]
        public result GetAcc(string acc)
        {
            result res = new result();
            User user = _iBLLUser.Find(x => x.UserId == 1 && x.UserName == acc);
            res.information = user;
            return res;
        }

    }
}
