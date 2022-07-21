/*
//Inferência de tipo
var salario = 10000.5;

//Ponto Flutuante - tipos específicos informados 
decimal salario1 = 1000.5m;
double salario2 = 1000.5d;
float salario3 = 1000.5f;

//Texto
string nome = "Texto string";

//Char
char id = '1';

//Verdadei ou falso
bool boleano = true;

//Inteiros
Int16 idade = 16;
int idade2 = 32;
long idade3 = 20;
Int64 idade4 = 24;
//Tipo de variável nome da variável = atribuição do valor
*/

//Console.WriteLine("Hello, World!");

Console.WriteLine("Digite o seu salário: ");
var salario = Console.ReadLine();
double c_salario = Convert.ToDouble(salario);

if (c_salario <= 1903.98)
{
    Console.WriteLine(c_salario);
}

if (c_salario >= 1903.99 && c_salario <= 2826.65)
{
    double desconto = ((c_salario - (c_salario * 0.925)) - 142.80);
   
    Console.WriteLine(c_salario - desconto);
}

if (c_salario >= 2826.66 && c_salario <= 3751.05)
{
    double desconto = (c_salario - (c_salario * 0.85)) - 354.80d;
   
    Console.WriteLine(c_salario - desconto);
}

if (c_salario >= 3751.06 && c_salario <= 4664.68)
{
    double desconto = (c_salario - (c_salario * 0.775))  - 636.13d;
   
    Console.WriteLine(c_salario - desconto);
}

if (c_salario >= 4664.69 )
{
    double desconto = (c_salario - (c_salario * 0.725)) - 869.36d;
   
    Console.WriteLine(c_salario - desconto);
}




