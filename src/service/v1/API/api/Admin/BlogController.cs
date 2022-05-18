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
        public async Task<IActionResult> Blog([FromBody] add_blog blog)
        {
            _result.Instance();
            var data = _mapper.Map<Blog>(blog);
            bool res = await _bLLBlog.AddOneBlog(data);
            if (res)
                _result.Success();
            else
                _result.Fail(500, "新增失败");
            return Content(JsonConvert.SerializeObject(_result));
        }

        /// <summary>
        /// 删除一条blog
        /// </summary>
        /// <param name="id">blog id</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Blog([FromBody] int id)
        {
            _result.Instance();
            bool res = await _bLLBlog.DeleteBlog(x => x.BlogId == id);
            if (res)
                _result.Success();
            else
                _result.Fail(500, "删除失败");
            return Content(JsonConvert.SerializeObject(_result));
        }

        /// <summary>
        /// 编辑blog文字
        /// </summary>
        /// <param name="blogs"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Blog([FromBody] List<edit_blog> blogs)
        {
            _result.Instance();
            var data = _mapper.Map<List<Blog>>(blogs);
            bool res = await _bLLBlog.UpdateBlog(data);
            if (res)
                _result.Success();
            else
                _result.Fail(500, "删除失败");
            return Content(JsonConvert.SerializeObject(_result));
        }

        [HttpGet]
        public IActionResult Blog([FromQuery] query_blog blog)
        {
            _result.Instance();
            _result.Fail(500, "");
            var map = _mapper.Map<Blog>(blog);

            var data = _bLLBlog.Where(x => x.BlogId == map.BlogId);
            if (data.Count() > 0)
            {
                var data_res = _mapper.Map<List<query_blog>>(data);
                _result.Success(JArray.FromObject(data_res));
            }
            else
                _result.Fail(500, "删除失败");
            return Content(JsonConvert.SerializeObject(_result));
        }
    }
}
