Console.WriteLine("escriba su nombre");
var nombre = Console.ReadLine();
Console.WriteLine("escriba su edad");
var edad = int.Parse(Console.ReadLine());


if (edad > 18)
{
    Console.WriteLine("usted es mayor a 18");
}
else
{
    Console.WriteLine("Usted es menor a 18");
}

for (int i = 0; i < 10; i++)
{
   Console.WriteLine(i+1);
}