class Program
{
    static void Main(String[] args)
    {
        double num1, num2, num3;
        Console.Write("Introduce el número 1 --> ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el número 2 --> ");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el número 3 --> ");
        num3 = Convert.ToDouble(Console.ReadLine());

        double media = (num1 + num2 + num3) / 3;

        Console.WriteLine($"La media de la suma de {num1}, {num2} y {num3} es {media}");
    }
}
