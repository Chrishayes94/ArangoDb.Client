using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArangoDb.Client.Http
{
    public static class HttpContentExtensions
    {
        public static async Task<TObject> ReadAsAsync<TObject>(this HttpContent content, JsonSerializerOptions jsonSerializerOptions = default)
        {
            if (content == null) throw new ArgumentNullException(nameof(content));

            var stream = await content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<TObject>(stream, jsonSerializerOptions);
        }
    }
}