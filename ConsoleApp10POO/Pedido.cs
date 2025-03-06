namespace ConsoleApp10POO
{
    public class Pedido
    {
        public int Numpedido;
        
        public List<Produto> PedidosLista= new List<Produto>();


        public double Total1()
        {
            double total = 0;
            foreach (Produto produto in PedidosLista)
            {
                total += produto.Preco;
            }
            return total;
        }
        public void Print() 
        {
            Console.WriteLine($"Pedido {Numpedido}");
            Console.WriteLine("Itens:");
            foreach (Produto produto in PedidosLista)
            {
                Console.WriteLine(produto.Prato);
            }
            Console.WriteLine($"Total: {Total1()}\n");
        }
    }
}
