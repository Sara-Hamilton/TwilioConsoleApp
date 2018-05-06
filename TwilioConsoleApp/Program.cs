using System;
using RestSharp;
using RestSharp.Authenticators;

namespace TwilioConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            //2
            var request = new RestRequest("Accounts/AC3550e4dff6b856dd28c607546152a5ff/Messages", Method.POST);
            //3
            request.AddParameter("To", "+15038914310");
            request.AddParameter("From", "+19714074952");
            request.AddParameter("Body", "Hello world!");
            //4
            client.Authenticator = new HttpBasicAuthenticator("AC3550e4dff6b856dd28c607546152a5ff", "dec2056fbac0def3976ad2fe13ed1e96");
            //5
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response);
            });
            Console.ReadLine();
        }
    }
}
