using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, n;

            string[,] alunos = new string[3, 2];
            alunos[0, 0] = "Marcio";
            alunos[0, 1] = "10";

            alunos[1, 0] = "Cezar";
            alunos[1, 1] = "8";

            alunos[2, 0] = "Gabriel";
            alunos[2, 1] = "7";

            string al 
            for ( int linha = 0; linha<3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++);
                {

                }
            }


            Console.WriteLine("Digite quantos elementos possue a primiera linha");
            m = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite quantos elementos possue a primiera coluna ");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine(" Você está trabalhando com uma matriz " + m + "X" + n );

            Console.ReadKey();


        }
    }
}
