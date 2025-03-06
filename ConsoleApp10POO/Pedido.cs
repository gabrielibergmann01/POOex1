namespace ConsoleApp10POO
{
    public class Pedido
    {
        public string Prato { get; set; }
        public string Pratinho { get; set; }

        public void DizerOi()
        {
            Console.WriteLine($"{Prato} tem no cardápio");

        }
    }
}
