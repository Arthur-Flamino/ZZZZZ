//Questão 1

// Console.Write("QUESTÃO 1\n");
// Console.Write("Digite num 1: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Digite num 2: ");
// int num2 = int.Parse(Console.ReadLine());

// int soma = num1 + num2;

// Console.WriteLine($"Soma: {soma}");

//------------------------------------------------------------------------------------

//Questão 2

// Console.Write("QUESTÃO 2\n");
// Console.Write("Digite num 1: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Digite num 2: ");
// int num2 = int.Parse(Console.ReadLine());

// if (num1 > num2){
//     Console.WriteLine($"O num 1 é maior");
// }else if (num2 > num1){
//     Console.WriteLine($"O num 2 é maior");
// }else{
//     Console.WriteLine($"Os numeros são iguais");
// }

//------------------------------------------------------------------------------------

//Questão 3

// Console.Write("QUESTÃO 3\n");
// Console.Write("Digite num 1: ");
// int num1 = int.Parse(Console.ReadLine());

// if(num1 % 2 == 0){
//     Console.WriteLine($"É par");
// }else
// {
//     Console.WriteLine($"É impar");
// }

//------------------------------------------------------------------------------------

//Questão 4

// Console.Write("QUESTÃO 4\n");
// Console.Write("Digite num 1: ");
// int num1 = int.Parse(Console.ReadLine());

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{num1} * {i} = {num1*i}");
// }

//------------------------------------------------------------------------------------

//Questão 5

Console.Write("QUESTÃO 5\n");
Console.Write("Digite num 1: ");
int num1 = int.Parse(Console.ReadLine());

if(num1 <=0){ 
    Console.WriteLine($"O fatorial de {num1} é 1");
}else{
    long resultado = 1;
    for (int i = 1; i <= num1; i++)
    {
        resultado *= i;
    }
    Console.WriteLine($"O fatorial de {num1} é {resultado}");
}