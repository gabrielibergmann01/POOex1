using System.Runtime.Serialization.Formatters;

namespace ConsoleApp10POO
{
    public class operação
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Pedido> pedidos = new List<Pedido>();   

        public void Cadastrar()
        {
            Produto produto = new Produto();
            Console.WriteLine("Digite o nome do produto:");
            produto.Prato = Console.ReadLine();
            Console.WriteLine("Digite o preço:");
            produto.Preco = double.Parse(Console.ReadLine());
            produtos.Add(produto);
            Console.WriteLine("Produto cadastrado");
        }

        public void ListaProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Você não cadastrou nenhum produto!");
            } 
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"{i} - Produto: {produtos[i].Prato} = {produtos[i].Preco} reais");
               
            }

        }

        public void Fazerpedido()
        {
            ListaProdutos();
            int numeropedido = pedidos.Count + 1;
            Pedido novopedido = new Pedido(numeropedido);
            Console.WriteLine("Qual produto você deseja:");
            int opcao = int.Parse(Console.ReadLine());
            novopedido.Produtos.Add(produtos[opcao]);
            Console.WriteLine("Pedido realizado!");
        }
        public double Valor()
        {
            double valor = 0;
            foreach (var produtos in produtos)
            {
                valor += produtos.Preco;
            }
            return valor;
        }

        public void PedidosFeitos()
        {
            
            Console.WriteLine("Pedidos feitos:");
            ListaProdutos();
             
            Console.WriteLine($"Valor: {Valor()}");
        }
        
    }
}
