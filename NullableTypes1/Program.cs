Console.WriteLine("## Nullable Types ##");

int valor = 100;
Console.WriteLine(valor);

// int valor1 = null;

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

// Ouu

int? a = null;
double? c = null;
bool? t = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);


int? z = null;
// int x = z;
int x = z ?? 0;

Console.WriteLine(x);

int? g = 100;

if(g.HasValue)
{
    Console.WriteLine($"g = {g.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}

Console.ReadKey();