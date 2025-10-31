class Program
{
    public static void Main(String[] args)
    {
        //Dado un número de dos cifras, diseñar un algoritmo que permita obtener el número invertido.
        //📘 Ejemplo:
        //Si se introduce 23, el programa debe mostrar 32.

        //Este ejercicio parece falcil pero debemos aplicar muy bien la logica de programacion y es mas complicado de lo que parece

        // Aqui creamos la variable num y leemos por teclado parseando a entero
        int num;
        Console.Write("Introduce un número de dos cifras: ");
        num = Convert.ToInt32(Console.ReadLine());

        //Tenemos que comprobar que el número que hemos introducido sea de dos cifras:
        // tiene que ser un numero entre 10 y 99
        if (num < 10 || num > 99) // lo que hace comprueba si el numero es menor que 10 o si el numero es mayor que 99 si esto ocurre no seria valido
        {
            Console.WriteLine("ERROR: El numero introducido no es de dos cifras");
        }
        else //Si pasa el bloque del if es decir que el num es de dos cifras y podriamos seguir el ejercicio
        {
            //Ahora tenemos que separar la variable num que es un entero es decir que no cuenta los decimales en decenas y unidades
            int decenas = num / 10; // Esto nos da el conciente de la division si por ejemplo es 23 / 10 = 2,3 pero es int entonces solo toma el 2
            int unidades = num % 10; // Esto nos da el resto de la division que de 23 / 10 el resto es 3

            //Lo que tenemos que hacer es invertirlo que lo que haremos sera las unidades las multiplimos y le sumamos las decenas
            int numInvertido = (unidades * 10) + decenas;
            Console.WriteLine($"El numero invertido sera {numInvertido}");
        }

    }
}
