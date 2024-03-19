Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
DateTime hoje = DateTime.Now;
Console.WriteLine(dataAtual);

// Criar uma data específica, usa formato: aaaa, mm, dd
DateTime dataHoje = new DateTime(2022, 09, 06);
Console.WriteLine(dataHoje);

// Definir as horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);

// Extrair informações da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

// Adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(1));
Console.WriteLine(hoje.AddYears(5));

Console.ReadKey();
