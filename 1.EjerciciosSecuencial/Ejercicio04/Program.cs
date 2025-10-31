class Program
{
    public static void Main(string[] args)
    {
        //Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.
        Console.WriteLine("================  CONVERSOR DE  FAHRENHEIT A CELSIUS  =================");
        Console.Write("Introduce los grados en  Fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        double celsius = (f - 32) * 5 / 9;
        Console.WriteLine($"RESULTADO --> {f:F1} grados Fahrenheit son {celsius:F1} grados Celsius");
        Console.WriteLine("=======================================================================");

        //Este ejercicio es muy similar a los anteriores recogemos por teclado aplicamos la formula que nos facilita el ejercicio e imprimimos es importante en este ejercicio redondear con un decimal
        // que esto lo conseguimos con :F1
    }
}
