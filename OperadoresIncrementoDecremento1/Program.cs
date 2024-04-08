Console.WriteLine("## Operadores Incremento e Decremento ##\n");

int x = 10;
x--; // é igual à -> x = x - 1 

Console.WriteLine(x);



// Pós-incremento -> primeiro resolve depois incrementa
int y = 0;
Console.WriteLine($"y = {y}");
int resultado1 = y++ + 10;

Console.WriteLine($"pós-incremento => {resultado1}");
Console.WriteLine($"valor de y => {y}\n");

// Pré-incremento -> primeiro incrementa depois resolve
int y2 = 0;
Console.WriteLine($"y = {y2}");
int resultado2 = ++y2 + 10;

Console.WriteLine($"pré-incremento => {resultado2}");
Console.WriteLine($"valor de y => {y2}\n");

// Pós-decremento -> primeiro resolve depois decrementa
int y3 = 0;
Console.WriteLine($"y = {y3}");
int resultado3 = y3-- + 10;

Console.WriteLine($"pós-decremento => {resultado3}");
Console.WriteLine($"valor de y => {y3}\n");

// Pré-decremento -> primeiro decremneta depois resolve
int y4 = 0;
Console.WriteLine($"y = {y4}");
int resultado4 = --y4 + 10;

Console.WriteLine($"pré-decremento => {resultado4}");
Console.WriteLine($"valor de y => {y4}\n");

Console.ReadKey();