using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Client
    {
        public async Task<object> RetornaCep(string cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            var json = JsonConvert.DeserializeObject<Address>(await response.Content.ReadAsStringAsync());

            Console.WriteLine(json);

            return response;
        }
    }
}
