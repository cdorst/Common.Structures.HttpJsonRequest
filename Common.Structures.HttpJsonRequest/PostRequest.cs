using System.Net.Http;

namespace Common.Structures.HttpJsonRequest
{
    public class PostRequest : ApiRequest
    {
        public PostRequest(string baseAddress, string path, string jsonContent)
            : base(baseAddress, path, HttpMethod.Post, jsonContent)
        {
        }
    }

}
