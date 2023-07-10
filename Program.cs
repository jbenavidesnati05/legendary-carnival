using Humanizer;

Console.WriteLine("ingrese un nombre");
var nombre = Console.ReadLine();

Console.WriteLine("ingrese un cargo");
var cargo = Console.ReadLine();

Console.WriteLine("ingrese su edad");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años ");