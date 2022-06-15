namespace _8_Condicionais2;
class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Testando Condicionais" + "\n");

        int idade = 17;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Seja Bem-Vindo.");
        }
        else
        {
            Console.WriteLine("Não Pode Entrar");
        }






        Console.WriteLine("\n" + "ENTER para sair...");
        Console.ReadLine();

    }

}