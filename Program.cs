
Console.WriteLine("");
Console.WriteLine("--- BIENVENIDOS A NUESTRO PROYECTO ---");
Console.WriteLine("");

Console.WriteLine("-- Para calcular los datos de tu triangulo --");
Console.WriteLine("");
Console.WriteLine("- Por favor ingresa el lado #1");
Console.WriteLine("");
int ladoA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("- Ahora el lado #2");
Console.WriteLine("");
int ladoB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("- Finalmente el lado #3");
Console.WriteLine("");
int ladoC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------");

if (ladoA == ladoB && ladoB == ladoC)
{
    Console.WriteLine("Tu triangulito es Equilatero");
    Console.WriteLine("");
    Console.WriteLine("   /\\");
    Console.WriteLine("  /  \\");
    Console.WriteLine(" /    \\");
    Console.WriteLine("/______\\");
    Console.WriteLine("");
    Console.WriteLine($"Porque todos sus lados son iguales ( lado 1 = {ladoA}, lado 2 = {ladoB} y lado 3 = {ladoC} )");
}

    else if (ladoA != ladoB && ladoB == ladoC ||ladoB != ladoA && ladoA == ladoC || ladoC != ladoA && ladoA == ladoB)
    {
        Console.WriteLine("Tu triangulito es Isosceles");
        Console.WriteLine("");
        Console.WriteLine("   /\\");
        Console.WriteLine("  /  \\");
        Console.WriteLine(" /    \\");
        Console.WriteLine("/______\\");
        Console.WriteLine("");
    }

    else if (ladoA != ladoB && ladoB != ladoC)
    {
        Console.WriteLine("Tu triangulito es Escaleno");
        Console.WriteLine("");
        Console.WriteLine("   /\\");
        Console.WriteLine("  /  \\");
        Console.WriteLine(" /    \\");
        Console.WriteLine("/______\\");
        Console.WriteLine("");
    }
else{}