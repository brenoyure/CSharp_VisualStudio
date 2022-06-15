namespace _9_Escopo_Exercicio
{

    class Program
    {

        static void Main(string[]args) 
        {

            Console.WriteLine("Testando Escopo de Variáveis" + "\n");
            
            
            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado;
            
            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja Bem-Vindo(a).");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar.");
            }




            Console.WriteLine("\n" + "ENTER para sair...");
            Console.ReadLine();


        }

    }

}