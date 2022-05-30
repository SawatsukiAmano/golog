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
        //private readonly IBLLUser _iBLLUser;
        private readonly IBLLBlog _iBLLBlog;
        private result _result;
        public LoginController(IBLLUser bLLUser, IBLLBlog bLLBlog)
        {
            //_iBLLUser = bLLUser;
            _iBLLBlog = bLLBlog;
            _result = CommonHelper.StaticHelper.api_result;
        }

        [HttpGet]
        public string GetTest()
        {
            return "连接成功" + DateTime.Now + "nya";
        }


        //[HttpGet]
        //public async Task<result> GetAcc(string acc)
        //{
        //    _result.Instance();
        //    var user = await _iBLLUser.FirstOrDefaultSync(x => x.UserName == acc);
        //    if (user == null)
        //        _result.Fail();
        //    else
        //        _result.Success(JObject.FromObject(user));
        //    return _result;
        //}


        [HttpGet]
        public async Task<result> TestBlog()
        {
            _result.Instance();
            var user = await _iBLLBlog.FirstOrDefaultSync(x => x.BlogId != null);
            if (user == null)
                _result.Fail();
            else
                _result.Success(JObject.FromObject(user));
            return _result;
        }
    }
}
