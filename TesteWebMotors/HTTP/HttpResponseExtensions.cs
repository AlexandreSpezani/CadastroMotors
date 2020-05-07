using Newtonsoft.Json;
using System.Net.Http;

namespace TesteWebMotors.HTTP
{
    public static class HttpResponseExtensions
    {

        public static T ContentAsType<T>(this HttpResponseMessage response)
        {
            var data = response.Content.ReadAsStringAsync().Result;
            return string.IsNullOrEmpty(data) ? default(T) : JsonConvert.DeserializeObject<T>(data);
        }

        public static string ContentAsJson<T>(HttpResponseMessage response)
        {
            var data = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.SerializeObject(data);
        }

        public static string ContentAsString<T>(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }

    }
}
