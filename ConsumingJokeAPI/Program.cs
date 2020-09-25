using System;
using System.Net.Http;
using System.Text;

namespace ConsumingJokeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string urlAPI = SelectFlags();
        }

        private static string SelectFlags()
        {
            StringBuilder urlTemp = new StringBuilder();
            urlTemp.Append("https://sv443.net/jokeapi/v2/joke/Any");
            int input = 0;

            Console.WriteLine("Deseja filtrar resultados? [1 = Sim | 2 = Não]: ");
            input = Int32.Parse(Console.ReadLine());
            if (input == 1) 
            {
                urlTemp.Append("?blacklistFlags=");
                    
                Console.WriteLine("Filtrar NSFW? [1 = Sim | 2 = Não]: ");
                input = Int32.Parse(Console.ReadLine());
                if (input == 1) urlTemp.Append("nsfw");
                

            }

           
            

                return null;
        }

        public static async void StartWebApi()
        {
            string urlAPI = "";
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, );
        }

        //newtonsoftjson
    }
}
