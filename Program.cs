using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Este projeto utiliza:
            //  - variáveis do tipo int
            //  - condicionais
            //  - operador lógico &&
            //  - loop while e for
            //  - expressão switch  

            int dificuldade = 0;
            var console = "";
            int acertos = 0;

            // Escolher dificuldade
            while(dificuldade !=  1 && dificuldade != 2 && dificuldade != 3)
            {
                Console.Clear();

                Console.WriteLine("1 - Fácil");
                Console.WriteLine("2 - Médio");
                Console.WriteLine("3 - Difícil"); 
                
                Console.Write("\nDigite a dificuldade desejada: ");

                console = Console.ReadLine();

                switch(console)
                {
                    case "1":
                        dificuldade = 1;
                        break;
                    case "2":
                        dificuldade = 2;
                        break;
                    case "3":
                        dificuldade = 3;
                        break;
                    default:
                        Console.WriteLine("\nNível não-identificado.");
                        Console.WriteLine("Pressione qualquer tecla para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
            
            // Gerar 10 cálculos, conforme o nível
            for(var i = 1; i <= 10; i++)
            {
                int primeiroFator;
                int segundoFator;

                Random rnd = new Random();
                if(dificuldade == 1)                 // Dificuldade 1
                {
                    primeiroFator = rnd.Next(0, 6);
                    segundoFator = rnd.Next(0, 6);
                } else if(dificuldade == 2)          // Dificuldade 2
                {
                    primeiroFator = rnd.Next(2, 11);
                    segundoFator = rnd.Next(2,11);
                } else {                             // Dificuldade 3
                    primeiroFator = rnd.Next(2,11);
                    segundoFator = rnd.Next(10, 21);
                }

                var resultado = (primeiroFator * segundoFator).ToString();
                Console.Write(primeiroFator + " X " + segundoFator + " = ");
                
                console = Console.ReadLine();

                // Exibir retorno
                if (console == resultado)
                {
                    Console.WriteLine("Correto! \n");
                    acertos++;
                } else {
                    Console.WriteLine("Incorreto!");
                    Console.WriteLine("A resposta é " + resultado + ". \n");
                }
            }

            Console.WriteLine("Você acertou " + acertos + " cálculo(s).");
            Console.ReadLine();
        }
    }
}