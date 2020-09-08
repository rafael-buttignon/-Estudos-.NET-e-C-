using Caelum.Stella.CSharp.Http;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "15997104";
            string result = GetEndereco(cep);

            Debug.WriteLine(result);
            Console.WriteLine(result);

            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            string enderecoXML = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXML);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            
            Console.WriteLine(string.Format("Logadouro: {0} , Bairro: {1} ", endereco.Logradouro, endereco.Bairro));
        }

        private static string GetEndereco(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}
