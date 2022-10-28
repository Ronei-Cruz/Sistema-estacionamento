namespace Sistema_estacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoHora = 0;
        private decimal PrecoInicial = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string? placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa?.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");                
                int horas =  Int32.Parse(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoHora * horas; 

                Console.WriteLine($"O veículo {placa?.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}