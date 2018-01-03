using System;
using System.Net.Http;
using System.Text;

namespace Common.Structures.HttpJsonRequest
{
    public class ApiRequest
    {
        private const string ApplicationJson = "application/json";
        private const string UserAgentHeader = "User-Agent";
        private const string UserAgentValue = "System.Net.Http.HttpClient";

        public ApiRequest(string baseAddress, string path, HttpMethod verb, string jsonContent)
            : this(new Uri(baseAddress), path, verb, new StringContent(jsonContent, Encoding.UTF8, ApplicationJson))
        {
        }
        public ApiRequest(Uri baseAddress, string path, HttpMethod verb, HttpContent content)
        {
            BaseAddress = baseAddress;
            Content = content;
            Path = path;
            Verb = verb;
        }

        public Uri BaseAddress { get; set; }
        public HttpContent Content { get; set; }
        public string Path { get; set; }
        public HttpMethod Verb { get; set; }

        public HttpRequestMessage Message
        {
            get
            {
                var message = new HttpRequestMessage(Verb, Path) { Content = Content };
                message.Headers.Add(UserAgentHeader, UserAgentValue);
                return message;
            }
        }
    }

}
