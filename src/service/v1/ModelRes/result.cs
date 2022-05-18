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
            _result_info = new JObject();
        }
        public void Instance()
        {
            _code = 500;
            _result_info["sub_code"] = 404;
            _result_info["sub_msg"] = "请求失败";
        }

        public void Success()
        {
            _code = 200;
            _result_info["sub_code"] = 200;
            _result_info["sub_msg"] = "请求成功";
        }

        public void Success(JObject jobj)
        {
            _code = 200;
            _result_info["sub_code"] = 200;
            _result_info["sub_msg"] = "请求成功";
            _result_info["data"] = jobj;
        }

        public void Success(JArray jobj)
        {
            _code = 200;
            _result_info["sub_code"] = 200;
            _result_info["sub_msg"] = "请求成功";
            _result_info["data"] = jobj;
        }

        public void Fail(int code = 404, string sub_msg = "请求失败")
        {
            _code = 500;
            _result_info["sub_code"] = code;
            _result_info["sub_msg"] = sub_msg;
        }
        public void Fail(int code, string sub_msg, JObject jobj)
        {
            _code = 500;
            _result_info["sub_code"] = code;
            _result_info["sub_msg"] = sub_msg;
            _result_info["data"] = jobj;
        }

        public int code => _code;
        public JObject result_info => _result_info;

        private int _code { get; set; }

        private JObject _result_info { get; set; }

    }
}
