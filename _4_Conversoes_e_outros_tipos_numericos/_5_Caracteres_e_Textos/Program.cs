namespace _5_Caracteres_e_Textos;

public class Program {

    public static void Main(string[] args) {


        Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos" + "\n");


        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1);

        Console.WriteLine(letra);

        string primeiraFrase = "Alura Cursos";
        Console.WriteLine(primeiraFrase);

        string cursos = @"Cursos Disponíveis: 
        - GO 
        - C# 
        - Java";
        Console.WriteLine(cursos);









        Console.WriteLine("\n" + "ENTER para sair ...");
        Console.ReadLine();
    
    
    }

}