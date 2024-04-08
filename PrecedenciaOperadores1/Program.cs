Console.WriteLine("## Precedência de operadores ##\n");

int x = 10 - 2 * 3;
Console.WriteLine(x);

int y = (10 - 2) * 3;
Console.WriteLine(y);

bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

int a = 5, c = 6, d = 4;

int r = --a * c - (++d);

Console.ReadKey();  