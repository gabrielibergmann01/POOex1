namespace ConsoleApp10POO
{
    public class Pedido
    {
        public int Numeropedido;

        public List<Produto> Produtos;
              
        public Pedido(int n1)
        {
            Numeropedido = n1;
            Produtos = new List<Produto>();
        }
    }
}
