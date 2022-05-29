using Microsoft.AspNetCore.Http;
using ModelRes;
using Microsoft.AspNetCore.Mvc;
using Model;
using IBLL;
using Newtonsoft.Json.Linq;

namespace API.api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IBLLUser _iBLLUser;
        private result _result;
        public LoginController(IBLLUser bLLUser)
        {
            _iBLLUser = bLLUser;
            _result = CommonHelper.StaticHelper.api_result;
        }

        [HttpGet]
        public string GetTest()
        {
            return "连接成功" + DateTime.Now + "nya";
        }


        [HttpGet]
        public async Task<result> GetAcc(string acc)
        {
            _result.Instance();
            var user = await _iBLLUser.FirstOrDefaultSync(x => x.UserName == acc);
            _result.Success(JObject.FromObject(user));
            return _result;
        }

    }
}
