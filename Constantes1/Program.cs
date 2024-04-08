using System.Reflection.Metadata.Ecma335;

Console.WriteLine("## Constantes ##\n");

const int ANO = 12;

const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

// calculo da áres e perímetro do círculo
double raio, perimetro, area;

const double PI = Math.PI;

Console.WriteLine("Informe o raio do círculo:");
raio = Convert.ToDouble(Console.ReadLine());


perimetro = 2 * PI * raio;
area = PI * Math.Pow(raio, 2);

Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Área = {area}");

Console.ReadKey();