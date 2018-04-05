using MercadoLibre.SDK;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaProdutoML
{
    class Program
    {
        private static Meli _Meli;
        private static long _ClientId; // Client ID da Aplicação do Mercado Livre
        private static string _ClientSecret; // Client Secret da Aplicação do Mercado Livre
        private static long _SellerId; // Id do Vendedor


        static void Main(string[] args)
        {
            try
            {
                LoginApi();
                WriteList(ParseProductJSON(GetMlListProducts()));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }
        }

        private static void LoginApi()
        {
            _Meli = new Meli(_ClientId, _ClientSecret); //Faz o login na API do mercado livre
        }

        private static string GetMlListProducts()
        {
            var products = _Meli.Get(String.Format("/sites/MLB/search?seller_id={0}&limit=5", _SellerId)); // Retorna a lista de produtos do Vendedor indicado (JSON)
            return products.Content;
        }

        private static dynamic ParseProductJSON(string MlResult)
        {
            JObject o = JObject.Parse(MlResult); // Parse JSON
            JArray results = (JArray)o.SelectToken("results"); // Quebra os Produtos

            return results;
        }

        private static void WriteList(dynamic products)
        {
            foreach (dynamic product in products) // Percorre a lista de produtos
            {
                Console.WriteLine(String.Format("ID : {0} || Nome : {1} || Preço : R${2}", product["id"].Value, product["title"].Value, Math.Round(Convert.ToDouble(product["price"].Value), 2)));
            }
        }
    }
}
