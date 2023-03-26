using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Lanyard
{
    /// <summary>
    /// Base HTTP client
    /// </summary>
    public abstract class BaseClient : IDisposable
    {
        protected HttpClient Client;
        protected JsonSerializer Serializer;
        //static BaseClient()
        //{
        //    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls13 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
        //}

        protected BaseClient(string EndPoint) : this(new Uri(EndPoint)) { }

        protected BaseClient(Uri EndPoint) : this() { Client.BaseAddress = EndPoint; }

        protected BaseClient()
        {
            Serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            };
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region Methods

        protected Task Delete(string path) => Request(path, null, HttpMethod.Delete);

        protected Task<T> Delete<T>(string path) => Request<T>(path, null, HttpMethod.Delete);

        protected Task<T> Get<T>(string path) => Request<T>(path, null, HttpMethod.Get);

#if NETCOREAPP

        protected Task Patch(string path, object data) => Request(path, data, HttpMethod.Patch);

        protected Task<T> Patch<T>(string path, object data) => Request<T>(path, data, HttpMethod.Patch);

#endif

        protected Task Put(string path, object data) => Request(path, data, HttpMethod.Put);

        #endregion Methods

        protected Task Request(string path, object data, HttpMethod method) => Request<object>(path, data, method);

        protected async Task<T> Request<T>(string path, HttpContent content, HttpMethod method)
        {
            using var Request = new HttpRequestMessage(method, path);
            if (content is not null) { Request.Content = content; }

            using var Responce = await Client.SendAsync(Request).ConfigureAwait(false);
            Responce.EnsureSuccessStatusCode();
            if (Responce.StatusCode == System.Net.HttpStatusCode.NoContent) { return default; }
            return await Deserialize<T>(Responce).ConfigureAwait(false);
        }

        protected async Task<T> Request<T>(string path, object data, HttpMethod method)
        {
            using var Request = new HttpRequestMessage(method, path);
            Request.Content = data switch
            {
                string str => new StringContent(str),
                not null => Serialize(data),
                null => null
            };

            //if (data is not null)
            //{
            //    Request.Content = new Serialize(data);
            //    Request.Content = new StringContent(data);
            //}
            using var Responce = await Client.SendAsync(Request).ConfigureAwait(false);
            Responce.EnsureSuccessStatusCode();
            if (Responce.StatusCode == System.Net.HttpStatusCode.NoContent) { return default; }
            return await Deserialize<T>(Responce).ConfigureAwait(false);
        }

        private static async Task<T> Deserialize<T>(HttpResponseMessage HRM)
        {
            var S = await HRM.Content.ReadAsStreamAsync().ConfigureAwait(false);
            if (S.Length == 0) { return default; }
            using var SR = new StreamReader(S);
            string Response = await SR.ReadToEndAsync();
            return JsonConvert.DeserializeObject<T>(Response);
        }

        private HttpContent Serialize(object data)
        {
            MemoryStream MS = new();
            using (var SW = new StreamWriter(MS, new UTF8Encoding(false), 1024, true))
            using (var JTW = new JsonTextWriter(SW) { Formatting = Formatting.None })
            {
                Serializer.Serialize(JTW, data);
                JTW.Flush();
            }
            MS.Seek(0, SeekOrigin.Begin);
            var SC = new StreamContent(MS);
            SC.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return SC;
        }

        #region Dispose

        public void Dispose()
        {
            ((IDisposable)Client).Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion Dispose
    }
}