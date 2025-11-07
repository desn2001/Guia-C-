class Program
{
    static void Main(string[] args)
    {
        //Calcular el perímetro y área de un rectángulo dada su base y su altura.
        double bas, altura; // No podemos usar la palabra "base" ya que en C# es una palabra reservada para herencia que veremos más adelante
        double perimetro; // El perimetro es la suma de todos sus lados

        Console.Write("Introduce la base de nuestro rectangulo: ");
        bas = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la altura de nuestro rectangulo: ");
        altura = Convert.ToDouble(Console.ReadLine());

        perimetro = (bas * 2) + (altura * 2);

        Console.WriteLine($"nuestro rectangulo con base de {bas}cm y altura de {altura}cm nos daria un perimetro de {perimetro}cm");
    }
}
