Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string"; // string são imutáveis

valor = "Isto é uma string alterada"; // Uma nova memória será criada para adicionar, ou seja, dois locais de memória.

// StringBuilder

// object pode receber qualquer tipo, útil quando não sabemos qual tipo de dados será utilizado
object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra = 'A';

// dynamic pode receber qualquer tipo, útil quando precisamos recursos avançados como Reflection(usado para retornar metadados de tipos em tempo de exec)
dynamic nota1 = 10;
dynamic valor2 = 8.55m;
dynamic nome2 = "Maria";
dynamic ativa1 = true;
dynamic letra1 = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();
