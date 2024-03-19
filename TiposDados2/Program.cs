Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234f; // Tem que colocar o 'f' no final para indicar que é float
decimal n3;
n3 = 1.234m;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.ReadLine();

Console.WriteLine("Comparando a precisão de float, double e decimal");

float x = 1f / 3f; // Precisão Menor
double y = 1d / 3d; // Precisão Média
decimal z = 1m / 3m; // Precisão Maior

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.ReadLine();