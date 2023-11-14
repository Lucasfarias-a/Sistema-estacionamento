namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Chama o método AdicionarVeiculo, passando a placa como argumento
            AdicionarVeiculo(placa);
        }

        public void AdicionarVeiculo(string placa)
        {
            // Verifica se a placa já está na lista
            if (!veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Adiciona a placa à lista de veículos
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Veículo com placa {placa} já está estacionado.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = int.Parse(Console.ReadLine());

                if (horas >= 0)
                {
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa.ToUpper());

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                //decimal valorTotal = 0;
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*                
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}