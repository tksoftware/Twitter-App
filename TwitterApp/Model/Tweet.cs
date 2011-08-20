using System;

namespace TwitterApp.Model
{
    public class Tweet
    {
        public String created_at { get; set; }
        public String from_user { get; set; }
        public String profile_image_url { get; set; }
        public String text { get; set; }
    }
}
