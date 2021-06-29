using System;
using System.Threading.Tasks;

namespace TesteWsCorreios
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digite o seu CEP");
            string cep = Console.ReadLine();
            await ConsultarCep(cep);
        }

        public static async Task ConsultarCep(string cep)
        {
            var correios = new Correios.AtendeClienteClient();
            var consulta = await correios.consultaCEPAsync(cep);

            Console.Clear();
            Console.WriteLine($"Bairro: { consulta.@return.bairro}");
            Console.WriteLine($"Cep: { consulta.@return.cep}");
            Console.WriteLine($"Cidade: { consulta.@return.cidade}");
            Console.WriteLine($"Complemento 2: { consulta.@return.complemento2}");
            Console.WriteLine($"Endereço: { consulta.@return.end}");
            Console.WriteLine($"Uf: { consulta.@return.uf}");
            Console.ReadKey();
        }
    }
}
