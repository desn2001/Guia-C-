# 🎓 Guía Completa de Programación Estructurada en C#

---

## 📊 Objetivo general
Aprender los fundamentos del lenguaje **C#** y la **programación estructurada**, utilizando **Visual Studio Code** como entorno de desarrollo.
Esta guía incluye teoría, ejemplos prácticos y ejercicios de:
- Variables y tipos de datos
- Operadores aritméticos y lógicos
- Entrada y salida por consola
- Condicionales (`if/else`, `switch`)
- Bucles (`for`, `while`, `do/while`) con explicación de contadores
- Funciones / modularidad
- Ejercicios prácticos finales

---

## 🧱 Módulo 1: Fundamentos de la Programación Estructurada

La **programación estructurada** organiza el código en **bloques lógicos y ordenados**, evitando saltos desordenados y facilitando la lectura y mantenimiento.

### Estructuras de control fundamentales
| Estructura | Descripción | Ejemplo |
|------------|-------------|---------|
| Secuencia | Instrucciones ejecutadas en orden | `Console.WriteLine("Hola");` |
| Selección | Toma de decisiones (`if/else`) | `if (edad >= 18) ...` |
| Iteración | Repetición de bloques (`for`, `while`, `do/while`) | `for(int i=0;i<5;i++)` |

### Características
- Modularidad: dividir el código en funciones.
- Claridad: buen uso de sangrías, nombres descriptivos y comentarios.
- Reutilización: usar funciones en distintas partes del programa.

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

## ➕ Módulo 3: Operadores aritméticos

```csharp
int num1 = 4, num2 = 2;
Console.WriteLine("Suma --> " + (num1 + num2));
Console.WriteLine("Resta --> " + (num1 - num2));
Console.WriteLine("Multiplicación --> " + (num1 * num2));
Console.WriteLine("División --> " + (num1 / num2));
Console.WriteLine("Módulo --> " + (num1 % num2));
```

---

## 🧠 Módulo 4: Operadores lógicos

```csharp
int edad = 25;
bool tieneLicencia = true;

// AND (&&)
if (edad >= 18 && tieneLicencia)
    Console.WriteLine("Puede conducir");

// OR (||)
if (edad < 18 || !tieneLicencia)
    Console.WriteLine("No puede conducir");

// NOT (!)
if (!tieneLicencia)
    Console.WriteLine("Necesitas una licencia");
```

| Operador | Descripción |
|----------|-------------|
| && | AND: ambas condiciones deben ser verdaderas |
| \|\| | OR: al menos una condición verdadera |
| ! | NOT: invierte el valor de la condición |

---

## ⌨️ Módulo 5: Entrada y salida por consola

```csharp
Console.Write("Introduce tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}");
```

- `Console.Write()` → no hace salto de línea
- `Console.WriteLine()` → hace salto de línea
- `Console.ReadLine()` → lee texto del usuario

---

## ⚖️ Módulo 6: Condicionales

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

## 🔁 Módulo 7: Bucles (explicado paso a paso)

> **Contador:** Una variable que usamos para saber cuántas veces se ha ejecutado un bucle. Generalmente se incrementa o decrementa en cada iteración.

### 7.1 Bucle for
**Paso a paso:**
1. Inicialización: `int i = 1` → contador comienza en 1
2. Condición: `i <= 5` → se repite mientras sea verdadera
3. Incremento: `i++` → suma 1 al contador cada vez

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteración {i}"); // i es el contador
}
```

### 7.2 Bucle while
**Paso a paso:**
1. Definir contador antes del bucle: `int i = 1`
2. Mientras la condición sea verdadera (`i <= 5`) se repite el bloque
3. Dentro del bloque incrementar contador `i++`

```csharp
int i = 1;
while (i <= 5)
{
    Console.WriteLine($"Iteración {i}");
    i++;
}
```

### 7.3 Bucle do/while
**Paso a paso:**
1. Se ejecuta el bloque **al menos una vez**
2. Luego se verifica la condición `i <= 5`
3. Repite mientras la condición sea verdadera

```csharp
int i = 1;
do
{
    Console.WriteLine($"Iteración {i}");
    i++;
} while (i <= 5);
```

---
## 🧮 Módulo 7: Arrays y Arrays Bidimensionales

### 🔹 ¿Qué es un array?
Un **array** almacena varios valores del mismo tipo en una sola variable.

```csharp
int[] numeros = { 10, 20, 30, 40, 50 };
Console.WriteLine(numeros[0]); // 10
Console.WriteLine(numeros[4]); // 50
```

### 🔹 Recorrer un array con for
```csharp
int[] edades = { 18, 20, 25, 30 };
for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine($"Edad {i}: {edades[i]}");
}
```

### 🔹 Arrays por teclado
```csharp
string[] nombres = new string[3];
for (int i = 0; i < nombres.Length; i++)
{
    Console.Write($"Introduce el nombre {i + 1}: ");
    nombres[i] = Console.ReadLine();
}
```

### 🔹 Arrays Bidimensionales (matrices)
```csharp
int[,] matriz = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for (int fila = 0; fila < matriz.GetLength(0); fila++)
{
    for (int col = 0; col < matriz.GetLength(1); col++)
    {
        Console.Write(matriz[fila, col] + " ");
    }
    Console.WriteLine();
}
```
---

## 🔹 Módulo 9: Funciones / Modularidad

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

- Permiten dividir el programa en bloques reutilizables
- Facilitan la lectura y depuración

---

## 🧱 Módulo 10: Buenas prácticas
- Nombres descriptivos: `edadAlumno`, `calcularPromedio()`
- Comentar el código: `// Esto calcula...`
- Mantener tabulación consistente
- Finalizar cada instrucción con `;`

---

## 🏋️ Módulo 11: Ejercicios prácticos finales

### Ejercicio 1: Ficha personal
- Pedir nombre, edad y mostrar un saludo y edad en meses.

### Ejercicio 2: Comparador de números
- Pedir dos números y mostrar cuál es mayor o si son iguales.

### Ejercicio 3: Tabla de multiplicar
- Pedir un número y mostrar su tabla del 1 al 10 usando `for`.

### Ejercicio 4: Bucles combinados
- Pedir un número y mostrar todas las iteraciones con `for`, `while` y `do/while`.

### Ejercicio 5: Decisión de conducir
- Pedir edad y si tiene licencia, usar operadores lógicos `&&`, `||`, `!` para determinar si puede conducir.

### Ejercicio 6: Días de la semana
- Pedir un número del 1 al 7 y mostrar el día correspondiente usando `switch`.

### Ejercicio 7: Función suma
- Crear una función que reciba dos números y devuelva la suma, luego mostrar el resultado.

### Ejercicio 8: Promedio 3 estudiantes
Calcular el promedio de 3 estudiantes con 2 notas cada uno:

### Ejercicio 9: Contador en bucles
- Crear un bucle que cuente cuántas veces un número introducido por el usuario es mayor que cero hasta que ingrese cero.

---

## 💬 Conclusión
Esta guía cubre los **fundamentos esenciales** de la programación estructurada en C#, la parte de los bucles y de las funciones son complicadas de entender de primeras, yo si quereis en el repositorio de git puedo subir ejercicios que me mandaros a mi en programacion de DAW y si teneis alguna duda me lo podeis preguntar por whassap o por discord

