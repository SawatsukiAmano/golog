

namespace API.api.Admin
{
    //[Authorize(Roles = "Logined")]
    public class BlogController : CoreController
    {
        private readonly IBLLBlog _bLLBlog;
        private readonly IMapper _mapper;

        public BlogController(IBLLBlog bLLBlog, IMapper mapper)
        {
            _bLLBlog = bLLBlog;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<List<query_blog>> Blogs()
        {
            var blogs = await _bLLBlog.WhereSync(x => x.BlogId > 0);
            var result = _mapper.Map<List<query_blog>>(blogs);
            return result;
        }


        ///// <summary>
        ///// 添加一条Blog
        ///// </summary>
        ///// <param name="formCollection"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<IActionResult> Blog([FromBody] add_blog blog)
        //{
        //    //_result.Instance();
        //    //var data = _mapper.Map<Blog>(blog);
        //    //bool res = await _bLLBlog.AddSync(data);
        //    //if (res)
        //    //    _result.Success();
        //    //else
        //    //    _result.Fail(500, "新增失败");
        //    return Content(JsonConvert.SerializeObject(""));
        //}

        ///// <summary>
        ///// 删除blog
        ///// </summary>
        ///// <param name="id">blog id</param>
        ///// <returns></returns>
        //[HttpDelete]
        //public async Task<IActionResult> Blog([FromBody] string idsStr)
        //{
        //    //_result.Instance();
        //    //var idsArr = Array.ConvertAll(idsStr.Split(","), int.Parse);
        //    //bool res = await _bLLBlog.DeleteSync(x => idsArr.Any(y => y == x.BlogId));
        //    //if (res)
        //    //    _result.Success();
        //    //else
        //    //    _result.Fail(500, "删除失败,该文章已不存在");
        //    return Content(JsonConvert.SerializeObject(""));
        //}

        ///// <summary>
        ///// 编辑blog文字
        ///// </summary>
        ///// <param name="blogs"></param>
        ///// <returns></returns>
        //[HttpPut]
        //public async Task<IActionResult> Blog([FromBody] edit_blog blogs)

        //{
        //    //_result.Instance();
        //    //var data = _mapper.Map<Blog>(blogs);
        //    //bool res = await _bLLBlog.UpdateSync(data);
        //    //if (res)
        //    //    _result.Success();
        //    //else
        //    //    _result.Fail(500, "修改失败");
        //    return Content(JsonConvert.SerializeObject(""));
        //}

        //[HttpGet]
        //public async Task<IActionResult> Blog([FromQuery] int id)
        //{
        //    //_result.Instance();
        //    //_result.Fail(500, "");
        //    //var data = await _bLLBlog.FirstOrDefaultSync(x => id == x.BlogId);
        //    //if (data != null)
        //    //{
        //    //    var data_res = _mapper.Map<List<query_blog>>(data);
        //    //    _result.Success(JArray.FromObject(data_res));
        //    //}
        //    //else
        //    //    _result.Fail(500, "查询失败，文章不存在");
        //    //return Content(JsonConvert.SerializeObject(_result));
        //    return Content(JsonConvert.SerializeObject(""));
        //}
    }
}
