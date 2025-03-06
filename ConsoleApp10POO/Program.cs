using System.Reflection.Metadata;

namespace ConsoleApp10POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.Prato = "Risole";

            pedido.DizerOi();

            Produto produto = new Produto();
            produto.cargo = "Juíz";
            produto.salario = 2.000;
            produto.Nome = "Luis";

            produto.Print();

            Produto produto1 = new Produto();

            produto.cargo = "amigo";
            produto.salario = 5.000;
            produto.Nome = "Mario";

            produto1.Print();

        }
    }
}