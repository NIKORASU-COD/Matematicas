
Console.WriteLine("\n--- BIENVENIDOS A NUESTRO PROYECTO ---");
Console.WriteLine("\n-- Para calcular los datos de tu triangulo --");
Console.WriteLine("\n- Por favor ingresa el lado #1");
double ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n- Ahora el lado #2");
double ladoB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n- Finalmente el lado #3");
double ladoC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n-----------------------------");

double anguloA = CalcularAngulo(ladoB , ladoC , ladoA);
double anguloB = CalcularAngulo(ladoA , ladoC , ladoB);
double anguloC = 180 - (anguloA + anguloB);
double CalcularAngulo(double lado1, double lado2, double lado3)
    {
        return Math.Acos((Math.Pow(lado1, 2) + Math.Pow(lado2, 2) - Math.Pow(lado3, 2)) / (2 * lado1 * lado2)) * (180 / Math.PI);
    }
if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)

    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("\nTu triangulito es Equilatero");
        Console.WriteLine("       /\\");
        Console.WriteLine("      /  \\");
        Console.WriteLine("     /____\\");
        Console.WriteLine($"\nPorque todos sus lados son iguales ( lado 1 = {ladoA}, lado 2 = {ladoB} y lado 3 = {ladoC} )");
        Console.WriteLine($"el angulo 1 es:{anguloA:F2}°");
        Console.WriteLine($"el angulo 2 es:{anguloB:F2}°");
        Console.WriteLine($"el angulo 3 es:{anguloC:F2}°");
    }

        else if (ladoA != ladoB && ladoB == ladoC ||ladoB != ladoA && ladoA == ladoC || ladoC != ladoA && ladoA == ladoB)
        {
            Console.WriteLine("\nTu triangulito es Isosceles");
            Console.WriteLine("");
            Console.WriteLine("       /\\");
            Console.WriteLine("      /  \\");
            Console.WriteLine("     /    \\");
            Console.WriteLine("    /______\\");
            Console.WriteLine("");
            Console.WriteLine($"el angulo 1 es:{anguloA:F2}°");
            Console.WriteLine($"el angulo 3 es:{anguloC:F2}°");
            Console.WriteLine($"el angulo 2 es:{anguloB:F2}°");
        }

        else if (ladoA != ladoB && ladoB != ladoC)
        {
            Console.WriteLine("\nTu triangulito es Escaleno");
            Console.WriteLine("\n       /\\");
            Console.WriteLine("      /  \\");
            Console.WriteLine("     /____\\");
            Console.WriteLine("");
            Console.WriteLine($"el angulo 3 es:{anguloC:F2}°");
            Console.WriteLine($"el angulo 1 es:{anguloA:F2}°");
            Console.WriteLine($"el angulo 2 es:{anguloB:F2}°");
        }
else
{
    Console.WriteLine("Los lados ingresados no forman un triangulo válido");
}
if(anguloA == 90 || anguloB == 90 || anguloC == 90){
    Console.WriteLine("Tu triangulo es un trianulo rectangulo");
}
else if(anguloA < 90 && anguloB < 90 && anguloC  <90){
    Console.WriteLine("Tu triangulo es un trianulo acutangulo");
} 
else if(anguloA > 90 || anguloB > 90 || anguloC > 90){
    Console.WriteLine("Tu triangulo es un trianulo obtusangulo");
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
// else{} shift + alt + flecha abajo = copia y pega la linea de cod

// Console.WriteLine("|\\");
// Console.WriteLine("| \\");
// Console.WriteLine("|  \\");
// Console.WriteLine("|   \\");
// Console.WriteLine("|____\\");

