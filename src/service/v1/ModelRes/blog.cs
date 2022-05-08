using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRes
{
    public class blog
    { 
        public int blog_id { get; set; }

        public string user_name { get; set; }
        
        public string blog_name { get; set; }
     
        public string category { get; set; }
        public DateTime created_time { get; set; }
   
        public DateTime lagtest_time { get; set; }
 
        public string curr_edit_txt { get; set; }

        public string view_txt { get; set; }
    }
}
