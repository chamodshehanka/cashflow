using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CashFlow.Services
{
    public class UserService
    {
        static HttpClient client = new HttpClient();
        public UserService()
        {
            this.client.BaseAddress = new Uri("http://localhost:5000/api/");
        }
    }
}