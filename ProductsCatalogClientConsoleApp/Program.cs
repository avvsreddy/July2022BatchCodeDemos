using System.Net.Http.Json;

namespace ProductsCatalogClientConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apiAddress = "https://localhost:44363/api/ProductsCatalog/1";
            HttpClient apiClient = new HttpClient();
            //var response = apiClient.GetStringAsync(apiAddress);
            var response = apiClient.GetAsync(apiAddress);
            //sdfsdfsd
            //sdfsdfd
            //sdfsdfsdf
            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var product = apiClient.GetFromJsonAsync<Product>(apiAddress).Result;
                Console.WriteLine(product.name + "\t" + product.price);
            }
            else
                Console.WriteLine("Product not found");


        }
    }
}