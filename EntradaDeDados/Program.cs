Console.WriteLine("\n ## Entrada de dados ##");

Console.WriteLine("\nInforme o seu nome");

string nome = Console.ReadLine(); // A entrada de dados precisa, necessariamente, ser do tipo string

Console.WriteLine("\nInforme a sua idade (ReadLine)");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme a sua idade (Read)");

int idade2 = Console.Read(); // Retorna o código ASCII do primeiro carectere do inteiro


Console.WriteLine("\nO seu nome é " + nome + " e você possui " + idade + " (ReadLine) e " + idade2 + " anos.");

Console.WriteLine($"\nO seu nome é {nome} e você possui {idade} (Read) e {idade2} anos.");

Console.ReadKey(); // Utilizado para segurar a tela