using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del vino:");
        string nombreVino = Console.ReadLine();

        Console.WriteLine("Ingrese el radio del tanque en metros:");
        double radio = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del tanque en metros:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tipo de material (madera o metal):");
        string tipoMaterial = Console.ReadLine();

        // Crear un objeto de la clase Tanque
        Tanque tanque = new Tanque(radio, altura, tipoMaterial);

        // Calcular el volumen y convertir a litros (1 m³ = 1000 litros)
        double volumenLitros = tanque.CalcularVolumen() * 1000;

        // Mostrar el mensaje final
        Console.WriteLine($"Hay {volumenLitros:F2} litros de {nombreVino} en un tanque de {tipoMaterial}.");
    }
}
