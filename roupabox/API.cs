using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class API
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            string apiUrl = "https://fakestoreapi.com/products";

            try
            {
                HttpsResponseMessage response = await client.GetAsync(apiUrl);


            }
        }
    }
}
