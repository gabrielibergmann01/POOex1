using System.Net;
using System.Reflection.Metadata;

namespace ConsoleApp10POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto produto1= new Produto();
            produto1.Prato = "Hamburguer";
            produto1.Preco = 24.99;
           
            Produto produto2 = new Produto();
            produto2.Prato = "Batata Frita";
            produto2.Preco = 15.00;

            Produto produto3 = new Produto();
            produto3.Prato = "Refrigerante";
            produto3.Preco = 5.00;

            Produto produto4 = new Produto();
            produto4.Prato = "Pizza";
            produto4.Preco = 69.99;

            Pedido pedido1 = new Pedido();
            pedido1.Numpedido = 1;
            pedido1.PedidosLista.Add(produto1);
            pedido1.PedidosLista.Add(produto3);

            Pedido pedido2 = new Pedido();
            pedido2.Numpedido = 2;
            pedido2.PedidosLista.Add(produto4);
            pedido2.PedidosLista.Add(produto3);

            pedido1.Print();
            pedido2.Print();
        }
    }
}