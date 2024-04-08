Console.WriteLine("## Conversão de tipos ##\n");

// Conversão implícita -> O compilador realiza a conversão automaticamente

// Quando realizada a conversão de uma variável com tipo de menor valor de armazenamteno, 
// para uma de maior valor, a conversão é feita de forma implícita.

int varInt = 100;
double varDouble = varInt;

//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

// Conversão forçada (Cast) -> Perda de precisão

double varDouble2 = 12.456; // 8 bytes
int varInt2 = (int)varDouble2; // 4 bytes 

Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2; // 10 / 4 = 2.5
Console.WriteLine(resultado);

Console.ReadLine();
