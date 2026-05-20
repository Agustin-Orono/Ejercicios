Console.WriteLine("que operacion quieres realizar");
Console.WriteLine("SUMA");
Console.WriteLine("RESTA");
Console.WriteLine("MULTIPLICACION");
Console.WriteLine("DIVICION");
string Operador = Console.ReadLine();

if (Operador.ToUpper() == "SUMA" )
{
    Console.WriteLine("ingrese el primer numero: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero: ");
    int N2 = int.Parse(Console.ReadLine());

    int Resultado = N1 + N2;

    Console.WriteLine("el resultado es: " + Resultado);

}
else if (Operador.ToUpper() == "RESTA")
{
    Console.WriteLine("ingrese el primer numero: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero: ");
    int N2 = int.Parse(Console.ReadLine());

    int Resultado = N1 - N2;

    Console.WriteLine("el resultado es: " + Resultado);

}
else if (Operador.ToUpper()== "MULTIPLICACION")
{
    Console.WriteLine("ingrese el primer numero: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero: ");
    int N2 = int.Parse(Console.ReadLine());

    int Resultado = N1 * N2;

    Console.WriteLine("el resultado es: " + Resultado);

}
else if (Operador.ToUpper() == "DIVISION")
{
    Console.WriteLine("ingrese el primer numero: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero: ");
    int N2 = int.Parse(Console.ReadLine());

    double Resultado = N1 / N2;

    Console.WriteLine("el resultado es: " + Resultado);

}
else
{
    Console.WriteLine("Operador desconocido. Selecciona una operacion de la lista.");
}
