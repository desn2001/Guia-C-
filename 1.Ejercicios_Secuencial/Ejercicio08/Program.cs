class Program
{
    public static void Main(string[] args)
    {
        //Diseñar un algoritmo que nos diga el dinero total que tenemos (en euros y céntimos)
        //Después de pedirnos cuántas monedas tenemos de:
        //-2 €
        //-1 €
        //-50 cent
        //-20 cent
        //-10 cent

        //Declaramos las variables que son necesarias 
        int monedas1, monedas2, monedas50, monedas20, monedas10;
        double contadorCent, contadorEuro;
        double total;

        //Recogemos por teclado cuantas monedas tenemos de cada una
        Console.Write("¿Cuantas monedas de 1 Euro tienes? ");
        monedas1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cuantas monedas de 2 Euro tienes? ");
        monedas2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cuantas monedas de 50 cent tienes? ");
        monedas50 = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cuantas monedas de 20 cent tienes? ");
        monedas20 = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cuantas monedas de 10 cent tienes? ");
        monedas10 = Convert.ToInt32(Console.ReadLine());

        //Aqui hacemos los calculos para saber cuantas monedas de euro y de centimos tenemos 
        contadorEuro = monedas1 + (monedas2 * 2);

        contadorCent = (monedas50 * 0.50) + (monedas20 * 0.20) + (monedas10 * 0.10);

        //Aqui tenemos que tener en cuenta que cada 100 centimos es igual a un euro por eso hacemos la comprobacion y si es mayor o igual a 100 le sumamos uno al contador de euros y restamos 100 al contador de centimos
        if (contadorCent >= 100)
        {
            contadorEuro = contadorEuro + 1;
            contadorCent = contadorCent - 100;
            total = contadorEuro + contadorCent;
            Console.WriteLine($"El resultado total seria de {total:F2}Euros");
        }
        else // y este bloque es lo que haria si pasa la comprobacion es decir si contador de centimos es menor de 100 solo suma los dos contadores e imprime el resultado
        {
            total = contadorEuro + contadorCent;
            Console.WriteLine($"El resultado total seria de {total:F2}Euros");
        }






    }
}

