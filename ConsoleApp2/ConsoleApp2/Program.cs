using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Insira o CEP");
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") };
            string Retorno = Console.ReadLine();
            HttpResponseMessage response = await client.GetAsync(Retorno + "/json/");
            string content = await response.Content.ReadAsStringAsync();
            Endereço jsonConvert = JsonConvert.DeserializeObject<Endereço>(content);
            Console.WriteLine(jsonConvert.Localidade);
            Console.ReadLine();
        }
    }
}