// See https://aka.ms/new-console-template for more information
using ConceptoCS;

Console.WriteLine("Hello, World!");


try
{
	Console.WriteLine(new Date(2023, 2, 29));
	Console.WriteLine(new Date(2023, 4, 2));
	Console.WriteLine(new Date(2023, 12, 32));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}