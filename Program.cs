double CalculoINSS(double salario)
{
    double descontoFaixaUm = 90.90;
    double descontoFaixaDois = 109.38;
    double descontoFaixaTres = 145.64;
    double descontoFaixaQuatro = 482.46;

    if (salario <= 1212.00)
    {
        var descontoVariavel = salario * 0.12;
        return Math.Round(descontoVariavel, 2);
    }
    if (salario > 1212.00  && salario <= 2427.35)
    {
        var descontoFixo = descontoFaixaUm;
        var descontoVariavel = ((salario - 1212.00) * 0.09) + descontoFixo;
        return Math.Round(descontoVariavel, 2);
    }
    if (salario >= 2427.36 && salario <= 3641.03)
    {
        var descontoFixo = descontoFaixaUm + descontoFaixaDois;
        var descontoVariavel = ((salario - 2427.36) * 0.12) + descontoFixo;
        return Math.Round(descontoVariavel, 2);
    }
    if (salario >= 3641.04 && salario <= 7087.22)
    {
        var descontoFixo = descontoFaixaUm + descontoFaixaDois + descontoFaixaTres;
        var descontoVariavel = ((salario - 3641.04) * 0.14) + descontoFixo;
        return Math.Round(descontoVariavel, 2);
    }
    if (salario > 7087.22)
    {
        var descontoFixo = descontoFaixaUm + descontoFaixaDois + descontoFaixaTres + descontoFaixaQuatro;
        return Math.Round(descontoFixo, 2);
    }
    return 0;
}
double CalculoIR(double salario)
{
    double c_salario = salario;
    double desconto = 0 ;

    if (c_salario <= 1903.98)
    {
    }
    if (c_salario >= 1903.99 && c_salario <= 2826.65)
    {
        desconto = ((c_salario - (c_salario * 0.925)) - 142.80);

    }
    if (c_salario >= 2826.66 && c_salario <= 3751.05)
    {
        desconto = (c_salario - (c_salario * 0.85)) - 354.80;

    }
    if (c_salario >= 3751.06 && c_salario <= 4664.68)
    {
        desconto = (c_salario - (c_salario * 0.775)) - 636.13;

    }
    if (c_salario >= 4664.69)
    {
        desconto = (c_salario - (c_salario * 0.725)) - 869.36;

    }
    return desconto;
}

//Método CalculaDescontos tem como objetivo calcular todos os descontos do salário
double CalculaDescontos(double salario)
{   
    //Criação da variável
    var salarioComDescontos = 0.0;

    salarioComDescontos = salario - CalculoIR(salario) - CalculoINSS(salario);
    return Math.Round(salarioComDescontos,2);
}

Console.WriteLine("Digite o salário");
double salario = Convert.ToDouble(Console.ReadLine());

var descontoINSS = CalculoINSS(salario);
var descontoIR = CalculoIR(salario);
double salarioliquido = salario - descontoIR - descontoINSS;

Console.WriteLine($"Desconto do IR: {Math.Round(descontoIR,2)}");
Console.WriteLine($"Desconto do INSS: {Math.Round(descontoINSS,2)}");
Console.WriteLine($"Seu salario é {salarioliquido}");

Console.WriteLine($"Salario líquido: {CalculaDescontos(salario)}");

