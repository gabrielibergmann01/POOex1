namespace ConsoleApp10POO
{
    public  class Produto
    {
        public string cargo { get; set; }
        public string Nome { get; set; }
        public double salario { get; set; }


        public void Print()
        {
            Console.WriteLine($"Cargo {cargo}");
            Console.WriteLine($"Salario Liquido {Salarioliquido()}");
        }

        public double Salarioliquido()
        {
            return salario * 0.73;
        }
    }
}
