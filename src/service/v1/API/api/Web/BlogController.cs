using AutoMapper;
using CommonHelper;
using IBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ModelRes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API.api.Web
{
    [Route("api1/[controller]/[action]")]
    [ApiController]
    public class WebBlogController : ControllerBase
    {
        private result _result;

        private readonly IBLLBlog _bLLBlog;
        private readonly IMapper _mapper;
        public WebBlogController(IBLLBlog bLLBlog, IMapper mapper)
        {
            _bLLBlog = bLLBlog;
            _mapper = mapper;
            _result = new result();
        }
        [HttpGet]
        public IActionResult Blog([FromQuery] query_blog blog)
        {
            _result.Instance();
            _result.Fail(500, "");
            var map = _mapper.Map<Blog>(blog);

            var data = _bLLBlog.FirstOrDefaultSync(x => x.BlogId == map.BlogId && x.ViewPower == -1);
            if (data != null)
            {
                var data_res = _mapper.Map<List<query_blog>>(data);
                _result.Success(JObject.FromObject(data_res));
            }
            else
                _result.Fail(500, "删除失败");
            return Content(JsonConvert.SerializeObject(_result));
        }
    }
}
