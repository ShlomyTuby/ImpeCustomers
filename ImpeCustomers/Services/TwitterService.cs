using Spring.Social.Twitter.Api;
using Spring.Social.Twitter.Api.Impl;
using Spring.Social.Twitter.Connect;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ImpeCustomers.Services
{
    public class TwitterService: IPostService
    {

        private ITwitter twitter; //new TwitterTemplate(consumerKey, consumerSecret, accessToken, accessTokenSecret);

        public  TwitterService()
        {
            string consumerKey = ConfigurationManager.AppSettings["TwitterConsumerKey"]; // The application's consumer key
            string consumerSecret = ConfigurationManager.AppSettings["TwitterConsumerSecret"]; // The application's consumer secret
            string accessToken = ConfigurationManager.AppSettings["TwitterAccessToken"];
            string accessTokenSecret = ConfigurationManager.AppSettings["TwitterAccessTokenSecret"];

            TwitterServiceProvider serviceProvider = new TwitterServiceProvider(consumerKey, consumerSecret);
            twitter = new TwitterTemplate(consumerKey, consumerSecret, accessToken, accessTokenSecret);      
        }

        public void PostMessage(string message) {
            twitter.TimelineOperations.UpdateStatusAsync(message)
                 .ContinueWith(task =>
                 {
                     //Console.WriteLine("IsCompleted " + task.IsCompleted + "!");
                 });
        }

    }
}