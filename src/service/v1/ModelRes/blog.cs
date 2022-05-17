using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRes
{
    public class add_blog
    {
        public string user_name { get; set; }

        public string blog_name { get; set; }

        public string category { get; set; }
        public DateTime create_time { get; set; }

        public DateTime lagtest_time { get; set; }

        public string curr_edit_txt { get; set; }

        public string view_txt { get; set; }
    }

    public class edit_blog
    {
        public int blog_id { get; set; }
        public string user_name { get; set; }

        public string blog_name { get; set; }

        public string category { get; set; }
        public DateTime create_time { get; set; }

        public DateTime lagtest_time { get; set; }

        public string curr_edit_txt { get; set; }

        public string view_txt { get; set; }
    }


    public class query_blog
    {
        public int blog_id { get; set; }
        public string? user_name { get; set; }

        public string? blog_name { get; set; }

        public string? category { get; set; }
        public DateTime? create_time { get; set; }

        public DateTime? lagtest_time { get; set; }

        public string? curr_edit_txt { get; set; }

        public string? view_txt { get; set; }
    }
}
