// Mi primer ejercicio en C#
Console.Write("Cual es tu nombre?");
string nombre = Console.ReadLine();

Console.Write("cuantos años tienes?");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("hola "+ nombre + ", sos mayor de edad.");
}
else
{
    Console.WriteLine("hola " + nombre + ", sos menor de edad.");
}