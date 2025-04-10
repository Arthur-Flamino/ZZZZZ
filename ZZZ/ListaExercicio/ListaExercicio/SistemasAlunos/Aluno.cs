using System;

namespace SistemasAlunos{

    public class Aluno{
        
    public string Nome {get; set;}
    public double Nota1 {get; set;}
    public double Nota2 {get; set;}

    public Aluno(string nome, double nota1, double nota2){

        this.Nome = nome;
        this.Nota1 = nota1;
        this.Nota2 = nota2;   
    }

    public double CalcularMedia(){
        return (Nota1 + Nota2)/2;
    }

    public void ExibirResultado(){
        double media = CalcularMedia();
        Console.WriteLine($"Aluno: {Nome}\nMedia: {media}");

        if(media >= 6){
            Console.WriteLine($"Aprovado");
        }else{
            Console.WriteLine($"Reprovado seu MERDA!!!!!!!");
        }
    }

    }


}