# C # 🚀️

# Comandos de consola

* `cd` -> Cambiar de directorio
* `mkdir` -> Crear una nueva carpeta
* `del` -> Borrar archivo
* `dotnet new console` -> Nuevo proyecto de aplicacion de consola
* `dotnet new mstests` -> Proyecto de Unit Testing
* `dotnet new web` -> Proyecto ASP.NET
* `dotnet build` -> Compila el programa y lo pasa a un dll.
* `dotnet run` -> Corre el programa
* `dotnet restore` -> Ponerlo siempre antes de correr cualquier aplicacion por primera vez
* `dotnet publish -c Debug -r win10-x64` -> Generar un .exe de la aplicacion para una arquitectura de 64 bits.
* `dotnet --info` -> Nos dara informacion sobre las versiones que tenemos.
* `dotnet -h` -> Para ver los comandos que tenemos disponibles

# ¿Qué es C#?

Es un lenguaje orientado a objetos que permite a los developers utilizar el framework .NET. Se puede usar para crear varias aplicaciones.

# Framework .NET

Para que C# pueda ser comprendido por nuestra CPU, debe haber un framework de por medio, en este caso, .NET. Este framework esta solo para Windows, pero, si usamos otra plataforma, tenemos **.NET Core** que es multiplataforma. 

Esta compuesto por:

* **Entorno en tiempo de ejecucion del lenguaje comun (CLR)** -> Se encarga de administrar el codigo en tiempo de ejecucion, dando servicios de administracion de memoria, exactitud del codigo y otros aspectos mas.
* **Libreria de Clase** -> Es una coleccion de clases, interfaces y tipos de clases que permiten lograr varias tareas de programacion comunes (Recoleccion datos, acceso a archivos, trabajo con texto, etc..)

# Console

`Console.WriteLine()` -> Mostrar el string en la consola
`Console.Clear()` -> Limpia la consola
`Console.ReadLine()` -> Lee la entrada del usuario (String)
`int.Parse(Console.ReadLine())` -> Lee la entrada del usuario que es un String y lo convierte a Int.

# Listas y Arrays

* El primer elemento es 0, es **zero-based**
* Creacion de una lista -> `List <String> listaColores = new List<String>();` otra manera es `var names = new List <string>();`
* Agregar elemento -> `listaColores.Add("Azul")`
* Ingresar elemento por consola ->

```
Console.WriteLine(“Ingrese un color”);

listaColores.Add(Console.ReadLine());
Console.WriteLine(“Ingrese un color”);

listaColores.Add(Console.ReadLine());
```

* Recorrer y mostrar los items de la lista ->

```
foreach (string item in listaColores)

{

Console.Writeline(item);

}
```

* Recorrido con For ->

```
for (int k = 0; k < colores.Length; k++)
            {
                Console.WriteLine("Color: " + colores[k]);
            }
```

* Crear un array con tamaño fijo y con items -> `string[] colores = new string[] { "azul", color, "blanco", "negro" }; `
* Separar los items del array por guiones ->

```
int[] ages = {30, 15, 20, 35};

var s = String.Join(“-”, ages);

Console.WriteLine(s);
```

* Ordenar un array de numeros de forma descendente -> `Array.sort(ages);`
* Saber cuantos elementos tiene un array (O un String, para saber cuantos caracteres tiene) -> `ages.length; `
* Si queremos insertar un elemento en cierto lugar de la lista -> `Lista.Insert(1 ,"valor)` al elemento que estaba en su lugar anteriormente (Si es que lo habia), se va a correr un lugar para adelante.
* Para eliminar un elemento de la lista -> `Lista.Remove(“Elemento”)`
* Si queremos eliminar un elemento de la lista por su index -> `List.RemoveAt(4)`
* Para saber si mi lista contiene a cierto elemento -> `Lista.Contains(“Elemento”)`
* Si quiero saber en que index esta cierto elemento -> `List.IndexOf(“Elemento”)` Si no existe, devuelve un -1
* Si quiero crear una lista a traves de un array ->

```c#
int[] array = { 1, 2, 3 };
var list = new List<int> (array);

string s = String.Join (", ", list);

Console.WriteLine (s);
```

# Diccionarios

El diccionario consta de un elemento y su respectiva key.

* Creamos el diccionario -> `Dictionary<string, int> dict = new Dictionary<string, int> ();`
* Podemos crear un diccionario e inicializarlo al mismo tiempo ->

  ```
  var dict = new Dictionary<int, string> () {
  {23, "Michael"},
  {91, "Dennis"}
  };

  ```
* Para agregar elementos al diccionario -> `dict.Add ("Ebenezer", 11);`
* Para acceder al elemento -> `dict["Ebenezer"]` Esto devuelve 11.
* Para saber la cantidad de elementos del diccionario -> `dict.Count`
* Si quiero ver todas las keys de mi diccionario ->

  ```c#
  var dict = new Dictionary<int, string> () {
  {4, "Locke"},
  {8, "Reyes"}};
  var s = String.Join (", ", dict.Keys); //Tambien con dict.Values por si queremos acceder a los valores
  Console.WriteLine (s);//Esto devuelve 4 y 8, que son las keys
  ```
* Si queremos borrar todo el diccionario ->  `Dicc.clear()`
* Si queremos ver si existe alguna Key -> `Dicc.ContainsKey(Key);`
* Para eliminar un elemento con cierta key -> ` Dicc.Remove(Key);`

# Validaciones

Validacion de entradas de texto por consola ->

```
Console.WriteLine(“Cuanta gente hay en tu familia?”);

int numerodemiembros = 0;

if (!int.TryParse(Console.ReadLine(), out numerodemiembros))

{

Console.WriteLine(“no válido”);

Environment.Exit(0) Fin de la depuración
}
```

Si la entrada por consola NO es un numero.

# Generar Random

```
Random r = new Random();

int num1 = r.Next(); --> Se genera cualquier número
int num1 = r.Next(10); --> Se le pone un máximo

int num1 = r.Next(10-100); --> Número de 10 a 100
```

Si quiero elegir un numero random de una lista..

```
int NumeroGanador = (new Random()).Next(0,participantes.count); --> Desde cero hasta el último participante inscripto

Console.WriteLine(Participantes [NumeroGanador];
```
