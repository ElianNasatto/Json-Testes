using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            //Download de um arquivo JSON
            string ola = client.DownloadString("https://localhost:44396/Home/Conjunto");

            //Download de um arquivo json de uma pagina de teste contendo seu ip
            string meuIp = client.DownloadString("http://ip.jsontest.com/");

            Console.WriteLine(meuIp);



            //Download de um arquivo PDF qualquer da internet para o caminho especificado
            client.DownloadFile("http://www.africau.edu/images/default/sample.pdf", @"C:\Users\elian\Desktop\TesteDownloadAlgumaCoisa.pdf");


            //Codigo abaixo de um 'ActionResult' do asp.net que busca um json de uma outra aplicacao web e o converte em listas de objetos para inserção 

            //public string Conjunto()
            //{
            //    string stringJson = System.IO.File.ReadAllText(@"C:\Users\elian\Desktop\este.json");
            //    var json = JsonConvert.DeserializeObject(stringJson);
            //    //var result = new { data = casa };
            //    return JsonConvert.SerializeObject(json);
            //}


            Console.ReadLine();
        }
    }
}
