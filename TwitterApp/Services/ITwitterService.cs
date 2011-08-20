using System;
using TwitterApp.Model;

namespace TwitterApp.Services
{
    public interface ITwitterService
    {

        void GetTweets(ResultCallback<Response> callback, String query);
        

    }
}
