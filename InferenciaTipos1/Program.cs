﻿Console.WriteLine("## Inferência Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

// var limitações
var salario = null;
var titulo;
var salario, imposto, total;

// Não pode mudar o tipo após inicializar
var num = 10;
num = num + 10;
num = "Teste";

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}

