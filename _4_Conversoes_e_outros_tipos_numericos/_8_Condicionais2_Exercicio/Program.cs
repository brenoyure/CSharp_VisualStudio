namespace _8_Condicionais2_Exercicio
{

    public class Program { 
    
        public static void Main(string[] args)
        {

            Console.WriteLine("\n" + "Testando Condicionais - 8 - Exercício." + "\n" + "\n");


            int idade = 18;
            int quantidadePessoas = 2;
            
            bool adulto = idade >= 18;
            bool acompanhado = quantidadePessoas >= 2;


            if (adulto && acompanhado)
            {
                Console.WriteLine("Seja Bem-Vindo.");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar.");
            }


            Console.WriteLine("\n" + "Pressione Enter para sair...");
            Console.ReadLine();
        }
    
    }

}
