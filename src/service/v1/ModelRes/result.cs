using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRes
{
    public class result
    {
        public result()
        {
            result_info = new JObject();
        }
        public void Instance()
        {
            code = 500;
            result_info["sub_code"] = 404;
            result_info["sub_msg"] = "请求失败";
        }

        public void Success()
        {
            code = 200;
            result_info["sub_code"] = 200;
            result_info["sub_msg"] = "请求成功";
        }

        public void Success(JObject jobj)
        {
            code = 200;
            result_info["sub_code"] = 200;
            result_info["sub_msg"] = "请求成功";
            data = jobj;
        }

        public void Fail(int code = 404, string sub_msg = "请求失败")
        {
            code = 500;
            result_info["sub_code"] = code;
            result_info["sub_msg"] = sub_msg;
        }
        public void Fail(int code, string sub_msg, JObject jobj)
        {
            code = 500;
            result_info["sub_code"] = code;
            result_info["sub_msg"] = sub_msg;
            data = jobj;
        }

        private int code { get; set; }

        private JObject result_info { get; set; }

        private JObject? data { get; set; }
    }
}
