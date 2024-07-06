using System.Runtime.Intrinsics.Arm;

namespace ConsumindoAPI {
    class Program {
        public static async Task Main(string[] args) {
            
            Console.WriteLine("Informe o CEP: ");
            string id = Console.ReadLine();

            CEPServices cepServices = new CEPServices();
            
            // CEP não existente para testes: 13171779
            // CEP existente para testes: 01153000

            while (id.Length != 8) {
                Console.WriteLine("Insira um CEP válido, sem espaços e traços, como no exemplo: 01153000");
                Console.WriteLine("Informe o CEP: ");
                id = Console.ReadLine();
            }

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