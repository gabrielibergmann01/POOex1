using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp10POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                operação operacao = new operação();
                int opcao;

                do
                {
                    Menu();
                    opcao = int.Parse(Console.ReadLine());
                    Escolhas(opcao, operacao);
                    if (opcao == 0)
                    {
                        Console.WriteLine("Saindo...");

                    } else if (opcao != 0)
                    {
                        Console.WriteLine("Digite Enter");
                        Console.ReadLine();
                    } 
                    Console.Clear();

                } while (opcao != 0);
                
                Console.WriteLine("Obrigada!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Opcão invalida");
            }

        }
        static void Menu()
        {
            Console.WriteLine("""
                1 - Cadastrar produto
                2 - Lista dos produtos
                3 - Fazer pedido 
                4 - Pedidos feitos
                0 - Sair
                """);
        }

        static void Escolhas(int opcao, operação operacao)
        {
           switch (opcao)
            {
                case 1:
                    operacao.Cadastrar();
                    break;
                case 2:
                    operacao.ListaProdutos();
                    break;
                case 3:
                    operacao.Fazerpedido();
                    break;
                case 4:
                    operacao.PedidosFeitos();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
    
}