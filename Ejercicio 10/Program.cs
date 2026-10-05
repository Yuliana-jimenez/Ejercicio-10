Console.WriteLine("SISTEMA DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto 
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente (A): ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados
Console.WriteLine();
motor1.MostrarDatos();
Console.WriteLine($"Estado: {motor1.ObtenerEstado()}");
Console.WriteLine($"Diagnóstico Temperatura: {motor1.VerificarTemperatura()}");

Console.ReadKey();

// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }

    // Método para mostrar los datos
    public void MostrarDatos()
    {
        Console.WriteLine();
        Console.WriteLine($"--- DATOS DEL MOTOR {Identificador} ---");
        Console.WriteLine($"Temperatura: {Temperatura} °C");
        Console.WriteLine($"Corriente: {Corriente} A");
        Console.WriteLine($"Velocidad: {Velocidad} RPM");
    }

    // Método para verificar temperatura > 70
    public string VerificarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "ALERTA - Temperatura mayor a 70°C";
        }
        else
        {
            return "Normal - Temperatura menor o igual a 70°C";
        }
    }

    // Método para determinar si está detenido o en marcha
    public string ObtenerEstado()
    {
        if (Velocidad == 0)
        {
            return "DETENIDO";
        }
        else
        {
            return "EN MARCHA";
        }
    }
}