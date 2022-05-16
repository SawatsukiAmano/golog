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
            var data = _mapper.Map<Blog>(blog);
            //bool res = await _bLLBlog.AddOneBlog(data);
            bool res = false;
            if (res)
                _result.Success();
            else
                _result.Fail(500, "新增失败");
            return Content(JsonConvert.SerializeObject(_result));
        }
    }
}
