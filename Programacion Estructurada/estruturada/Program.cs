//Esta es la estructura basica de un programa en C# que mas adelante enteremos lo que significa esta estructura ya que es un clase con un funcion estatica que es el main y es donde ira dentro todo 
//nuestro codigo.

//Tenemos que tener en cuenta diferentes cosas C# se distribuye por bloques que estan formados por las "{}" en la estructura basica tendremos el primer bloque que sera
//la clase Program si nos fijamos siempre las llaves tienes que tener claro donde se abren y donde se cierran y que esten a la misma altura de tabulacion para que nuestro codigo sea mas legible.

//Tambien si usamos dos barras diagonales creamos un comentario que esto nos sirve para guiarnos a nosotros y a futuros compañeros que lean nuestro codigo tener en cuenta que el ordenador no tiene
//en cuenta el codigo que esta entre comentarios.
class Program
{
    static void Main(string[] args)
    {
        //INTRODUCCION A C#
        //La siguiente linea es para que imprima por la consola el mensaje que escribamos tener en cuenta que tendremos que respetar las mayusculas del Console.WriteLine y lo mas importante
        //terminar con el ; ya que si no el programa al ejecutarlo dara fallo.

        //Console.WriteLine("Aprenderemos programacion estructurada con C#");

        //VARIABLES
        // Para declarar una variable tendremos que poner primero de que tipo es y depues un nombre para nuestra variable.

        int edad = 23; //esta en una variable int que sera un numero entero es decir no puede ser decimal.
        string nombre = "Diego"; //esta es una variable string que es una cadena de texto le podemos añadir lo que queramos pero nuestro programa lo tomara como texto tener en cuenta que las cadenas
                                 //de texto se tienen que poner entre dobles comas.
        double altura = 1.80; //esta variable es de tipo double y son de numeros decimales.
        bool estudiante = true; //esta es una variable booleano que esto significa que solo puede ser true o false nosotros lo iniciamos con true aunque se prodria iniciar false.

        //Imprimimos nuestras varibles por pantalla.
        Console.WriteLine(nombre);
        Console.WriteLine(edad);
        Console.WriteLine(altura);
        Console.WriteLine(estudiante);
        //de esta forma nos saldra por pantalla los valores que le hayamos dado a nuestras variables cada una en una linea.

        //Interpolacion VS concatenacion
        Console.WriteLine("============================= Ficha concatención =============================");
        Console.WriteLine("Nombre --> " + nombre + "\nEdad --> " + edad + "\nAltura --> " + altura + "cm" + "\n¿Es estudiante? --> " + estudiante);
        Console.WriteLine("==============================================================================");

        Console.WriteLine();

        Console.WriteLine("============================= Ficha interpolación =============================");
        Console.WriteLine($"Nombre --> {nombre}");
        Console.WriteLine($"Edad --> {edad}");
        Console.WriteLine($"Altura --> {altura}cm");
        Console.WriteLine($"¿Es estudiante? --> {estudiante}");
        Console.WriteLine("===============================================================================");

        //Aqui tenenmos las diferencia entre interpolacion y la concatenacion ambas daran el mismo resultado por pantalla esto nos demuestra que en programacion existen muchos caminos para llegar al
        //mismo sitio en la concatenacion se ve todo en la misma linea y tendremos que añadir nosotros los saltos de linea con "\n" y en la interpolacion lo que escribimos es mas similar a lo que se
        //nos imprimira por pantalla.

        //RECOGER DATOS POR TECLADO
        Console.Write("Introduce tu nombre: ");
        string nombre1 = Console.ReadLine();
        Console.Write("Introduce tu apellido: ");
        string apellido = Console.ReadLine();

        Console.WriteLine($"Hola me llamo {nombre1} {apellido}");
        //Aqui nos fijamos en varias cosas lo primero es que hemos hecho el Console.Write en vez de Console.WriteLine para que no me añada el salto de linea ponemos que nuestra variable sea
        //Console.ReadLine() esto nos quiere decir que lo escrito por teclado sera lo que se guarde en la variable nombre1 siempre lo guardara como cadena de texto es decir String.

        //PARSEAR --> lo que quiere decir parsear es como hemos dicho antes en el consele.readLine() solo recoge String pero si mas adelante queremos recoger un int para hacer una suma
        //tenemos que hacer que el programa interprete que es un int en resumen parsear es tranformar el String en int.

        Console.Write("Introduce tu edad: ");
        int edad1 = Convert.ToInt32(Console.ReadLine()); //Aqui lo que se entiende es que convertimos lo que lee por consola al tipo int.

        Console.Write("Introduce tu altura: ");
        double altura1 = Convert.ToDouble(Console.ReadLine()); //Aqui hace lo mismo pero con el double.

        Console.WriteLine($"Hola tengo {edad1} años y mido {altura1}cm");

        //OPERADORES ARITMETICOS "+","-","*","/" y "%"

        int num1 = 4, num2 = 2;

        Console.WriteLine("Suma --> " + (num1 + num2));
        Console.WriteLine("Resta --> " + (num1 - num2));
        Console.WriteLine("Multiplicacion --> " + (num1 * num2));
        Console.WriteLine("Division --> " + (num1 / num2));
        Console.WriteLine("Modulo --> " + (num1 % num2)); //Este es el operador aritmetico que quiza es mas raro respecto a los demas esto nos dara el resto de la division del num1 / num2

        //CONDICIONALES sirve para que el programa actue de una forma dependiendo de lo que le pasemos aqui usaremos la variable que recogemos por teclado llamada edad1
        if (edad1 >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("No eres mayor de edad");
        }
        //En este bloque esta bien ya que son solo dos condiciones.

        //Si existe varias condiciones (Vamos a usar las variables num1).
        if (num1 > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (num1 < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
        //Aqui se comprueba tres condiciones nos comprueba si el numero es positivo,negativo o cero cada uno con un mensaje gracias al if else 

        //Otra forma de hacer las condicionales multiples seria switch
        Console.Write("Introduce un número del 1 al 3: ");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Elegiste la opción 1");
                break;
            case 2:
                Console.WriteLine("Elegiste la opción 2");
                break;
            case 3:
                Console.WriteLine("Elegiste la opción 3");
                break;
        }

        //case define cada posible valor de la variable.
        //break detiene la ejecución del switch después de ejecutar un caso.
        //default se ejecuta si ningún caso coincide.



















    }
}
