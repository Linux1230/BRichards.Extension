using System.Net.Http.Headers;
using System.Text;

namespace Linux1230.Helper.HttpClientUtils
{
    public class WebApiConnection : IDisposable
    {
        public HttpClient Client { get; private set; }
        public Encoding DataEncoding { get; private set; }
        public string DataType { get; private set; }

        private const string URL = "https://localhost:44372/api/";

        public WebApiConnection()
        {
            DataEncoding = Encoding.UTF8;
            DataType = "application/json";
            Client = new HttpClient();
            Client.BaseAddress = new Uri(URL);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(DataType));
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
