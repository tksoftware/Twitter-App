using System;
using RestSharp;
using TwitterApp.Model;

namespace TwitterApp.Services
{

    public class TwitterService : ITwitterService
    {


        private readonly RestClient _client;
        private string baseUrl = "http://search.twitter.com/search.json";

        public TwitterService()
        {
            _client = new RestClient(baseUrl);
        }



        public void GetTweets(ResultCallback<Response> callback, string query)
        {
            var request = new RestRequest();

            request.AddParameter("q", query);

            _client.ExecuteAsync(request, (RestResponse<Response> restResponse) =>
                                             {
                                                 if (restResponse.ErrorException != null)
                                                     callback(new Result<Response>(restResponse.ErrorException));
                                                 else
                                                     callback(new Result<Response>(restResponse.Data));
                                             }


                );
        }
    }
}
