using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tanque
{
    public double Radio { get; set; }
    public double Altura { get; set; }
    public string TipoMaterial { get; set; }

    public Tanque(double radio, double altura, string tipo)
    {
        Radio = radio;
        Altura = altura;
        TipoMaterial = tipo;
    }

    // Método para calcular el volumen del tanque
    public double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio, 2) * Altura; // Volumen en metros cúbicos
    }
}
