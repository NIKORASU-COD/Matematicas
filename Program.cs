
Console.WriteLine("\n--- BIENVENIDOS A NUESTRO PROYECTO ---");
Console.WriteLine("\n-- Para calcular los datos de tu triangulo --");
Console.WriteLine("\n- Por favor ingresa el lado #1");
double ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n- Ahora el lado #2");
double ladoB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n- Finalmente el lado #3");
double ladoC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n-----------------------------");

if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)

    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("\nTu triangulito es Equilatero");
    
        Console.WriteLine("\n   /\\");
        Console.WriteLine("  /  \\");
        Console.WriteLine(" /    \\");
        Console.WriteLine("/______\\");
        Console.WriteLine($"\nPorque todos sus lados son iguales ( lado 1 = {ladoA}, lado 2 = {ladoB} y lado 3 = {ladoC} )");
    }

        else if (ladoA != ladoB && ladoB == ladoC ||ladoB != ladoA && ladoA == ladoC || ladoC != ladoA && ladoA == ladoB)
        {
            Console.WriteLine("\nTu triangulito es Isosceles");
            Console.WriteLine("");
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
            Console.WriteLine("");
        }

        else if (ladoA != ladoB && ladoB != ladoC)
        {
            Console.WriteLine("\nTu triangulito es Escaleno");
            Console.WriteLine("");
            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");
            Console.WriteLine("");
        }
    else{}

else
{
    Console.WriteLine("Los lados ingresados no forman un triangulo válido");
}

// double anguloA = 5;
// double anguloB = 5;
// double anguloC = 2;

// if (anguloA == 90 || anguloB == 90 || anguloC == 90)
// {
//     Console.WriteLine("Tu triangulo es Rectangulo");
// }
//     else if (anguloA < 90 && anguloB < 90 && anguloC <90)
//     {
//         Console.WriteLine("Tu triangulo es Acotangulo");
//     }
//     else if (anguloA > 90 || anguloB > 90 || anguloC > 90)
//     {
//         Console.WriteLine("Tu triangulo es Obtusangulo");
//     }
// else{}