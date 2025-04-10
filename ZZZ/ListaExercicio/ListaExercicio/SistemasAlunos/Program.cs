using System;
using System.Globalization;

namespace SistemasAlunos{
    class Program
    {
        static void Main(string [] args){

            Console.WriteLine("Digite nome Aluno: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Digite nota1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite nota2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno(nome, nota1, nota2);
            aluno.ExibirResultado();
        }
    }
}