namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 7");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Pode Entrar");

            }
            else
            {
                if (quantidadePessoas > 1)
                {
                    Console.WriteLine("Ele está acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Não pode entrar");
                }


            }

            Console.WriteLine("ENTER PARA SAIR...");
            Console.ReadLine();
        }
    }
}