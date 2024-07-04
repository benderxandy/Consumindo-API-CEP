using System.Runtime.Intrinsics.Arm;

namespace ConsumindoAPI {
    class Program {
        public static async Task Main(string[] args) {

            Console.WriteLine("Informe o CEP: ");
            int id = int.Parse(Console.ReadLine());

            CEPServices cepServices = new CEPServices();

            CEP cepEncontrado = await cepServices.Integracao(id);

            if (!cepEncontrado.Verificacao) {
                System.Console.WriteLine("CEP Encontrado");

                System.Console.WriteLine($"CEP: {cepEncontrado.cep}");
                System.Console.WriteLine($"Logradouro: {cepEncontrado.logradouro}");
                System.Console.WriteLine($"Bairro: {cepEncontrado.bairro}");
                System.Console.WriteLine($"Localidade: {cepEncontrado.localidade}");
                System.Console.WriteLine($"UF: {cepEncontrado.uf}");
                System.Console.WriteLine($"DDD: {cepEncontrado.ddd}");
            }
            else {
                System.Console.WriteLine("CEP não Encontrado");
            }
        }
    }
}