namespace _7_Condicionais_Exercicio;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Testando Condicionais" + "\n");


        int idade = 17;
        int quantidadePessoas = 1;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade." + "\n" + "Seja Bem-Vindo.");
        }
        else
        {
            if(quantidadePessoas > 1)
            {
                Console.WriteLine("Você é menor de idade, mas pode entrar, pois está acompanhado(a).");
            }
            else
            {
                Console.WriteLine("Você é menor de idade, e não está acompanhado(a). " + "\n" +
                                "infelizmente não pode entrar.");
            }
        }






        Console.WriteLine("\n" + "ENTER para sair...");
        Console.ReadLine();

    }

}