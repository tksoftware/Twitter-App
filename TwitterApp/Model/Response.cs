using System.Collections.Generic;

namespace TwitterApp.Model
{
    public class Response
    {
        public string completed_in { get; set; }
        public string max_id { get; set; }
        public string max_id_str { get; set; }
        public int page { get; set; }
        public string query { get; set; }
        public string refresh_url { get; set; }

        public List<Tweet> results { get; set; }
    }
}
