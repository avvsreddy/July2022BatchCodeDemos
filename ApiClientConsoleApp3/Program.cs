using System.Net.Http.Json;

namespace ApiClientConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            HttpClient client = new HttpClient();
            //var response = client.GetFromJsonAsync<Product>("https://localhost:44363/api//ProductsCatalog/11");
            //Console.WriteLine(response.Result.name);
            //return;
            var res = client.GetAsync("https://localhost:44363/api/ProductsCatalog/1");
            if (res.Result.IsSuccessStatusCode)
            {

                var product = res.Result.Content.ReadFromJsonAsync<Product>().Result;
                Console.WriteLine(product.name);
            }
            else
            {
                Console.WriteLine("Product not found");
            }

        }
    }
}