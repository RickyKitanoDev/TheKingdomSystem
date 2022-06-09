using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            await new Client().RetornaCep("60841525");
        }
    }
}
