# Ejercicios de Algoritmos de Búsqueda en C#

Este repositorio contiene una solución de Visual Studio desarrollada en C# utilizando Windows Forms (.NET Framework 4.7.2). El proyecto consiste en una aplicación principal que navega hacia seis ejercicios diferentes, cada uno diseñado para demostrar y visualizar el funcionamiento de distintos algoritmos de búsqueda y manipulación de datos.

## Descripción del Proyecto

La aplicación implementa algoritmos de búsqueda manuales (sin depender estrictamente de funciones prefabricadas como `Contains` o `IndexOf` para la lógica principal), permitiendo visualizar el comportamiento del algoritmo paso a paso en varios casos.

### Tecnologías Utilizadas
* Lenguaje: C#
* Framework: .NET Framework 4.7.2
* Tipo de Aplicación: Windows Forms (WinForms)
* IDE Recomendado: Visual Studio 2019 o superior

## Contenido de los Ejercicios

A continuación se detalla la lógica implementada en cada uno de los formularios:

### Ejercicio 1: Búsqueda lineal en un arreglo
El programa genera un arreglo de 20 números enteros aleatorios visibles en la interfaz.
* Solicita un número al usuario.
* Implementa una búsqueda lineal recorriendo los elementos uno por uno.
* Indica visualmente si el número existe y muestra su posición o un mensaje de error si no se encuentra.

### Ejercicio 2: Búsqueda binaria en una lista ordenada
El programa genera una lista de 30 números aleatorios.
* Ordena la lista numéricamente.
* Implementa el algoritmo de búsqueda binaria de forma manual.
* Muestra el proceso paso a paso, descartando mitades del arreglo (visualizando el límite inferior, medio y superior) hasta encontrar el valor o determinar que no existe.

### Ejercicio 3: Búsqueda de texto dentro de una cadena
Un módulo diseñado para el análisis de cadenas de texto.
* Recibe un párrafo de texto y una palabra a buscar.
* Realiza una búsqueda manual carácter por carácter para contar cuántas veces aparece la palabra.
* La búsqueda no distingue entre mayúsculas y minúsculas (case-insensitive).

### Ejercicio 4: Búsqueda de objetos en una colección
Se trabaja con una clase `Estudiante` que contiene las propiedades `Id` y `Nombre`. Se utiliza un DataGridView para mostrar un listado de al menos 10 estudiantes.
* **Búsqueda por ID:** Implementa una búsqueda lineal para localizar al estudiante por su identificador numérico.
* **Búsqueda por Nombre:** Implementa una búsqueda binaria basada en el nombre del estudiante (requiere que la colección esté ordenada alfabéticamente).

### Ejercicio 5: Búsqueda del valor máximo y mínimo
Este ejercicio gestiona una lista de números enteros ingresados o generados.
* Recorre la lista para encontrar el valor máximo y el valor mínimo.
* Calcula y muestra la cantidad de iteraciones necesarias para realizar la operación, sin utilizar los métodos directos `Max()` o `Min()` de LINQ para la lógica de comparación.

### Ejercicio 6 (Extra): Búsqueda en matriz 2D
Implementación de búsqueda sobre una estructura de datos bidimensional.
* Genera una matriz de 10x10 con números aleatorios.
* Solicita un número al usuario.
* Realiza una búsqueda exhaustiva recorriendo filas y columnas para encontrar todas las coincidencias del número dentro de la matriz.

## Instrucciones de Ejecución

1.  Clonar este repositorio o descargar el código fuente.
2.  Abrir el archivo de solución `Ejercicios.sln` con Visual Studio.
3.  Compilar la solución (Build).
4.  Ejecutar el proyecto (Start). Al iniciar, se mostrará un menú principal desde el cual se puede acceder a cada uno de los 6 ejercicios.