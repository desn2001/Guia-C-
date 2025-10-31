//Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto deberá pagar finalmente por su compra.
class Program
{
    public static void Main(string[] args)
    {
        double importe, importeDescuento;
        Console.Write("Introduce el importe total de la compra: ");
        importe = Convert.ToDouble(Console.ReadLine());

        double descuento = (importe * 15) / 100; //Tenemos que tener en cuenta que primero calculamos el descuento y despues se lo tenemos que restar al importe
        importeDescuento = importe - descuento;
        Console.Write($"La compra inicialmente nos cuesta {importe:F2} euros y cuando le aplicamos un 15% de descuento se nos queda {importeDescuento:F2} euros");
        //cuando ponemos double significa que nuestra variable es decimal dependiendo de los numeros puestos nos sera conveniente rendondear a un numero determinado de decimales que eso lo hacemos con :F2
    }
}
