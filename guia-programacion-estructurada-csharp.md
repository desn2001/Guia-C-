# 🎓 Guía Completa de Programación Estructurada en C# (Desde Cero)

---

## 📊 Objetivo general
Aprender los fundamentos del lenguaje **C#** y la **programación estructurada**, utilizando **Visual Studio Code** como entorno de desarrollo.  
Esta guía está pensada para personas **sin experiencia previa en programación**, e incluye teoría, ejemplos y ejercicios prácticos.

---

## 🖥️ ¿Qué es programar?

Programar es darle instrucciones al ordenador para que realice tareas, igual que una receta de cocina.  
Un programa en C# es un conjunto de **instrucciones que se ejecutan paso a paso**.  
Cada instrucción tiene un propósito: mostrar texto, pedir datos, realizar cálculos, tomar decisiones, etc.

---

## ⚙️ Cómo ejecutar tu primer programa en Visual Studio Code

1. Instala [Visual Studio Code](https://code.visualstudio.com/).
2. Instala el **SDK de .NET** desde [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
3. Abre VS Code y abre una nueva terminal integrada.
4. Crea un nuevo proyecto con:
   ```bash
   dotnet new console -n MiPrimerPrograma
   cd MiPrimerPrograma
   dotnet run
   ```
5. Verás que aparece en la consola:
   ```
   Hello, World!
   ```

¡Acabas de ejecutar tu primer programa en C#! 🎉

---

## 🧩 Módulo 0: Sintaxis básica y comentarios

Cada instrucción termina con un **punto y coma (;)**  
Los **bloques de código** se agrupan con llaves `{ }`.

```csharp
// Esto es un comentario: el programa lo ignora
Console.WriteLine("Hola mundo"); // Imprime texto por consola
```

| Símbolo | Significado |
|----------|-------------|
| `;` | Fin de una instrucción |
| `{ }` | Agrupan bloques de código |
| `()` | Usados para llamar funciones o pasar parámetros |
| `//` | Comentario de una línea |
| `/* ... */` | Comentario de varias líneas |

---

## 🧱 Módulo 1: Fundamentos de la Programación Estructurada

La **programación estructurada** organiza el código en **bloques lógicos y ordenados**, facilitando su lectura y mantenimiento.

### Estructuras de control fundamentales

| Estructura | Descripción | Ejemplo |
|------------|-------------|---------|
| Secuencia | Instrucciones ejecutadas en orden | `Console.WriteLine("Hola");` |
| Selección | Toma de decisiones (`if/else`) | `if (edad >= 18) ...` |
| Iteración | Repetición de bloques (`for`, `while`, `do/while`) | `for(int i=0;i<5;i++)` |

### Características
- **Modularidad**: dividir el código en funciones.  
- **Claridad**: usar nombres descriptivos y comentarios.  
- **Reutilización**: usar funciones varias veces.  

---

## 🔤 Módulo 2: Variables y tipos de datos

```csharp
int edad = 23;
string nombre = "Diego";
double altura = 1.80;
bool estudiante = true;

Console.WriteLine(nombre);
Console.WriteLine(edad);
Console.WriteLine(altura);
Console.WriteLine(estudiante);
```

| Tipo | Descripción | Ejemplo |
|------|-------------|---------|
| int | Números enteros | 23 |
| double | Números decimales | 1.80 |
| string | Texto | "Diego" |
| bool | Verdadero/Falso | true |

---

## 🧩 Módulo 3: Interpolación vs Concatenación de cadenas

Dos formas de mostrar texto junto con variables:

```csharp
string nombre = "Diego";
int edad = 23;
double altura = 1.80;
bool estudiante = true;

// Concatenación
Console.WriteLine("============================= Ficha concatenación =============================");
Console.WriteLine("Nombre --> " + nombre + "\nEdad --> " + edad + "\nAltura --> " + altura + "cm" + "\n¿Es estudiante? --> " + estudiante);
Console.WriteLine("==============================================================================");

Console.WriteLine();

// Interpolación
Console.WriteLine("============================= Ficha interpolación =============================");
Console.WriteLine($"Nombre --> {nombre}");
Console.WriteLine($"Edad --> {edad}");
Console.WriteLine($"Altura --> {altura}cm");
Console.WriteLine($"¿Es estudiante? --> {estudiante}");
Console.WriteLine("===============================================================================");
```

| Método | Sintaxis | Legibilidad |
|--------|-----------|--------------|
| Concatenación | `"Hola " + nombre + ", tienes " + edad + " años"` | Menos clara |
| Interpolación | `$"Hola {nombre}, tienes {edad} años"` | Más clara |

✅ **Conclusión:** ambas funcionan igual, pero la **interpolación** es más moderna y legible.

---

## ➕ Módulo 4: Operadores aritméticos

```csharp
int num1 = 4, num2 = 2;
Console.WriteLine("Suma --> " + (num1 + num2));
Console.WriteLine("Resta --> " + (num1 - num2));
Console.WriteLine("Multiplicación --> " + (num1 * num2));
Console.WriteLine("División --> " + (num1 / num2));
Console.WriteLine("Módulo --> " + (num1 % num2));
```

---

## 🧠 Módulo 5: Operadores lógicos

```csharp
int edad = 25;
bool tieneLicencia = true;

if (edad >= 18 && tieneLicencia)
    Console.WriteLine("Puede conducir");
else if (edad < 18 || !tieneLicencia)
    Console.WriteLine("No puede conducir");
```

| Operador | Descripción |
|----------|-------------|
| && | AND: ambas condiciones deben ser verdaderas |
| \|\| | OR: al menos una condición verdadera |
| ! | NOT: invierte el valor |

---

## ⌨️ Módulo 6: Entrada y salida por consola

```csharp
Console.Write("Introduce tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}");
```

---

## ⚖️ Módulo 7: Condicionales

### if/else
```csharp
int edad = 18;
if (edad >= 18)
    Console.WriteLine("Eres mayor de edad");
else
    Console.WriteLine("Eres menor de edad");
```

### switch
```csharp
Console.Write("Introduce un número del 1 al 3: ");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1: Console.WriteLine("Opción 1"); break;
    case 2: Console.WriteLine("Opción 2"); break;
    case 3: Console.WriteLine("Opción 3"); break;
    default: Console.WriteLine("Opción no válida"); break;
}
```

---

## 🔁 Módulo 8: Bucles

### for
```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteración {i}");
}
```

### while
```csharp
int i = 1;
while (i <= 5)
{
    Console.WriteLine($"Iteración {i}");
    i++;
}
```

### do/while
```csharp
int i = 1;
do
{
    Console.WriteLine($"Iteración {i}");
    i++;
} while (i <= 5);
```

---

## 🧮 Módulo 9: Arrays y Arrays Bidimensionales

### Arrays
```csharp
int[] numeros = { 10, 20, 30, 40, 50 };
Console.WriteLine(numeros[0]); // 10
```

### Arrays por teclado
```csharp
string[] nombres = new string[3];
for (int i = 0; i < nombres.Length; i++)
{
    Console.Write($"Introduce el nombre {i + 1}: ");
    nombres[i] = Console.ReadLine();
}
```

### Arrays Bidimensionales
```csharp
int[,] matriz = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};
```

---

## 🔹 Módulo 10: Funciones / Modularidad

```csharp
static int Sumar(int a, int b)
{
    return a + b;
}

static void Main()
{
    int resultado = Sumar(4,5);
    Console.WriteLine($"Resultado: {resultado}");
}
```

---

## 🧱 Módulo 11: Buenas prácticas
- Usa **nombres descriptivos**: `edadAlumno`, `calcularPromedio()`.  
- Comenta tu código.  
- Mantén la **tabulación uniforme**.  
- Finaliza cada instrucción con `;`.  

---

## ⚠️ Módulo 12: Errores comunes de principiantes

1. **Olvidar el punto y coma (;)**
2. **Confundir asignación (=) con comparación (==)**
3. **Olvidar cerrar comillas o llaves**
4. **Usar variables sin inicializar**
5. **No convertir tipos de datos correctamente**

---

## 🧠 Módulo 13: Glosario básico

| Término | Significado |
|----------|-------------|
| Variable | Espacio en memoria donde se guarda un valor |
| Compilador | Traduce el código a lenguaje máquina |
| Consola | Ventana donde se muestran mensajes o se leen datos |
| Función | Bloque de código que realiza una tarea específica |
| Condicional | Instrucción que toma decisiones |
| Bucle | Estructura que repite instrucciones |

---

## 🏋️ Módulo 14: Ejercicios prácticos finales

1. Ficha personal – Pedir nombre, edad y mostrar saludo y edad en meses.
2. Comparador de números – Pedir dos números y mostrar cuál es mayor.
3. Tabla de multiplicar – Pedir un número y mostrar su tabla del 1 al 10.
4. Bucles combinados – Mostrar iteraciones con `for`, `while` y `do/while`.
5. Decisión de conducir – Usar operadores lógicos `&&`, `||`, `!`.
6. Días de la semana – Mostrar día según número del 1 al 7 con `switch`.
7. Función suma – Crear función que devuelva la suma de dos números.
8. Promedio 3 estudiantes – Calcular promedio de notas.
9. Contador en bucles – Contar cuántas veces un número es mayor que cero.

---

## 💬 Conclusión

Esta guía cubre los fundamentos esenciales de la programación estructurada en C#.  
Incluye teoría, práctica, buenas costumbres y errores comunes.  
Con ella podrás dar tus primeros pasos en programación desde cero 🚀
