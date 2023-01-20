// See https://aka.ms/new-console-template for more information

int idade1; //Correto inicia com ZERO (default);
int idade2 = 25; //Correto inicia com 25;
//var idade3; //Errado, dever ser inicializado.


var texto = "Testando";
Console.WriteLine(texto);


const int IDADE_MINIMA = 0; //Correto, inicia com ZERO;
//const var IDADE = 2; //Errado, a constante não pode ter uma variável com var


Console.WriteLine(IDADE_MINIMA);

byte meuByte = 127;
sbyte meubyteNegativo = -127;

int? idade = null!;
Console.WriteLine($"Idade: {idade}");

int inteiro = int.Parse("100"); //É uma extensão dos tipos primitivos.

int inteiro2 = Convert.ToInt32(100);

//***
int inteiro3 = 0;
Console.WriteLine(inteiro3);

float real = 25.5f;
Console.WriteLine(real);

real = inteiro3; //Conversão implícita.
inteiro3 = (int)real; //Conversão Explícita.

Console.WriteLine($"inteiro: {inteiro3}");
int inteiro4 = int.Parse("12");
Console.WriteLine($"Inteiro: {inteiro4}");

//Operadores Aritimétidos.

//Laços de repetição.
Console.WriteLine("Laços de repetição");
for(int i=0; i<5; i++) {
    for(int j =0; j<2; j++)
        Console.WriteLine($"i:{i} - j:{j}");
}
    