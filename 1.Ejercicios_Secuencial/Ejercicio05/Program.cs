class Program
{
    public static void Main(string[] args)
    {
        //Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas.
        //El vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes, y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.
        
        //Podemos declarar todas las variables de una o por separado como vayamos necesitando eso realmente da igual el programa funcionara de todos modos
        double sueldoBase, venta1, venta2, venta3, comision, total;

        //Pedimos por teclado los datos necesarios
        Console.Write("Introduce el sueldo base del vendedor: ");
        sueldoBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el valor de la primera venta: ");
        venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el valor de la segunda venta: ");
        venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el valor de la tercera venta: ");
        venta3 = Convert.ToDouble(Console.ReadLine());


        //Aqui calculamos la comision que se llevara el vendedor que sera el 10% de total de la suma de las tres ventas mensuales
        comision = (venta1 + venta2 + venta3) * 0.10;

        //Aqui calculamos el total que seria la suma del sueldo base mas la comison 
        total = (sueldoBase + comision);

        //Ahora imprimimos los resultados
        Console.WriteLine("================== RESULTADO ==================");
        Console.WriteLine($"Comision recibida este mes es de ---> {comision:F2}"); //Como ya hemos hecho anteriormente usamos el :F2 para que se redondear a dos decimales
        Console.WriteLine($"Total a cobrar este mes es de ---> {total:F2}");
        Console.WriteLine("===============================================");

    }
}
