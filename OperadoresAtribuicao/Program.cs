using System.Drawing;

Console.WriteLine("## Operadores de atribuição ##\n");

// Usando operadores atribuição com tipos numéricos
var x = 10;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 {x += 5}");
Console.WriteLine($"x -= 3 {x -= 5}");
Console.WriteLine($"x *= 4 {x *= 5}");
Console.WriteLine($"x /= 5 {x /= 5}");
Console.WriteLine($"x %= 5 {x %= 5}");

var y = "123";

Console.WriteLine($"Valor inicial de y = {y}");

y += "456";
Console.WriteLine($"Y += \"456\" {y}");

Console.ReadKey();