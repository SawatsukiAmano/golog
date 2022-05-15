using AutoMapper;
using CommonHelper;
using IBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ModelRes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API.api.Admin
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private result _result;

        private readonly IBLLBlog _bLLBlog;
        private readonly IMapper _mapper;


        public BlogController(IBLLBlog bLLBlog, IMapper mapper)
        {
            _result = StaticHelper.api_result;
            _bLLBlog = bLLBlog;

            _mapper = mapper;
        }

        /// <summary>
        /// 添加一条Blog
        /// </summary>
        /// <param name="formCollection"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOneBlog([FromBody] blog blog)
        {
            _result.Instance();
            Blog data = _mapper.Map<Blog>(blog);
            data.BlogName = "测试名称";
            //bool res = await _bLLBlog.AddOneBlog(data);
            bool res = true;
            if (res)
                _result.Success();
            else
                _result.Fail(500, "新增失败");
            return Content(JsonConvert.SerializeObject(_result));
        }
    }
}
