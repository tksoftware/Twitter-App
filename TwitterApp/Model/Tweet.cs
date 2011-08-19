using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

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
