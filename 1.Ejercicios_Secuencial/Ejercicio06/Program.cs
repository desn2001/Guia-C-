class Program
{
    public static void Main(string[] args)
    {
        //Un alumno desea saber cuál será su calificación final en la materia de Algoritmos.
        //Dicha calificación se compone de los siguientes porcentajes:

        //-55% del promedio de sus tres calificaciones parciales.
        //-30% de la calificación del examen final.
        //-15% de la calificación de un trabajo final.

        //Primero declaramos las variables
        double nota1, nota2, nota3, notaExFinal, trabajoFinal;
        double mediaParciales;
        double notaFinal;

        //Ahora recogemos los datos para despues poder hacer los calculos
        Console.Write("Introduce tu nota del primer parcial: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce tu nota del segundo parcial: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce tu nota del tercer parcial: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce tu nota del examen final: ");
        notaExFinal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce tu nota del trabajo final: ");
        trabajoFinal = Convert.ToDouble(Console.ReadLine());

        //Calculamos la media de los tres parciales 
        mediaParciales = (nota1 + nota2 + nota3) / 3;

        //Aqui le hacemos directamente el porciento que nos indica arriba 
        notaFinal = (mediaParciales * 0.55) + (notaExFinal * 0.30) + (trabajoFinal * 0.15);

        Console.WriteLine($"Tu nota final en la asignatura de Algoritmos es de {notaFinal:F2}");






    }
}
