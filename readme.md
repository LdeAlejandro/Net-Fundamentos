
#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso

# Program.cs

- Repositorio GitHub: https://github.com/LdeAlejandro/Net-Fundamentos.git.
- Documento relacionado a la practica: [[Doc Pessoa.cs]]
- Codigo: [[Programacion/Net/Cursos/Curso Net Dio/Bootcamp Avanade/Fundamentos Net/Program.cs|Program.cs]]
## **1. Creación y Uso de Objetos**

**Descripción:** Esta sección se centra en la creación y manipulación de objetos en C#. Se utiliza la clase `Pessoa` del espacio de nombres `ExemploFundamentos.Common.Models` como ejemplo.

**Uso:**

1. Instanciar un objeto `Pessoa` .
2. Asignar valores a sus propiedades como `Nome` e `Idade`.
3. Invocar métodos definidos en la clase, como `Apresentar()`.

```c#
using ExemploFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Buta";
pessoa1.Idade = 26;
pessoa1.Apresentar();
```

## 2. **Conversión de Variables (Casting)**

**Descripción:** Aquí se exploran diferentes métodos para convertir datos entre tipos, incluyendo Parse, Convert y ToString.

**Uso:**

1. `int.Parse(string)` convierte una cadena en un entero.
2. `Convert.ToInt32(object)` convierte un objeto en un entero.
3. `ToString()` convierte un entero en una cadena.

**Consideraciones:**

- `Parse` puede lanzar una excepción si la cadena no es convertible a entero.
- `Convert` devuelve 0 si el objeto es nulo o no es convertible a entero.

```c#
// Conversión explícita usando Parse
int a = int.Parse("5");

// Parse permite null en la variable (arroja una excepción)
int a = int.Parse(null); // Esto lanzará una excepción

// Convert permite null en la variable
int a = Convert.ToInt32(null); // Esto dará 0

// Conversión de int a string
int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);
```

## 3. Conversión Segura con TryParse

**Descripción:** Se muestra cómo usar `int.TryParse()` para convertir una cadena en un entero de manera segura sin lanzar excepciones.

**Uso:**

1. Intenta convertir una cadena en un entero utilizando `int.TryParse()`.
2. Si la conversión es exitosa, el valor se asigna a la variable de salida, de lo contrario, permanece sin cambios.
```c#

string a = "15-";
int b = 0;

// TryParse intenta convertir y si no puede, b sigue siendo 0
int.TryParse(a, out b);
Console.WriteLine(b);
```

4. Estructuras de Control: Switch y Bucles

**Descripción:** Se demuestra el uso de `switch` para comparar cadenas y bucles como `do-while` para la entrada iterativa del usuario.

**Uso:**

1. `switch`: Evalúa una expresión y ejecuta código basado en diferentes casos.
2. `do-while`: Ejecuta un bloque de código al menos una vez y luego se repite mientras se cumple una condición.

```c#

// Ejemplo de uso de switch con cadenas
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case var inputted when "aeiou".Contains(inputted):
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

// Ejemplo de do-while
int numero = 0;
do 
{
    Console.WriteLine("Digite un numero (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero != 0);
```


## 5. Creación de Menú Interactivo

**Descripción:** Se crea un menú interactivo utilizando un bucle `while` y una estructura de control `switch`.

**Uso:**

1. Presenta al usuario un menú de opciones.
2. El usuario selecciona una opción.
3. Según la opción seleccionada, se realiza una acción específica.

```c#

string opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.WriteLine("***\nDigite sua opção:\n1 - Cadastrar cliente\n2 - Buscar cliente\n3 - Apagar cliente\n4 - Encerrar\n***");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Buscar de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}
```


## 6. Arrays y Operaciones con Arrays

**Descripción:** Introduce el uso de matrices (arrays) en C# y muestra cómo realizar operaciones básicas como copiar elementos.

**Uso:**

1. Declara y asigna valores a un array.
2. Utiliza bucles `foreach` para iterar sobre los elementos del array.
3. Usa `Array.Copy()` para copiar elementos de un array a otro.
4. 
```c#

int[] arrayInteiros = new int[4] { 72, 64, 50, 1 };
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, 2);

int contadorInteiros = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"ArrayInteiros Valor: {valor} - Posição {contadorInteiros}");
    contadorInteiros++;
}

int contadorInteirosDobrado = 0;
foreach (int valor in arrayInteirosDobrado)
{
    Console.WriteLine($"ArrayDobrados Valor: {valor} - Posição Dobrados {contadorInteirosDobrado}");
    contadorInteirosDobrado++;
}
```

## 7. Uso de Listas

**Descripción:** Se utiliza la clase `List<T>` para almacenar y manipular una colección de elementos en C#.

**Uso:**

1. Crea una lista.
2. Agrega elementos a la lista usando `Add()`.
3. Accede a los elementos de la lista mediante índices o iteración.
```c#

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição {i} - Estado {listaString[i]}");
}
```

## 8. Desafíos de Coding The Future Avanade

**Descripción:** Se utiliza la clase `List<T>` para almacenar y manipular una colección de elementos en C#.

**Uso:**

1. Crea una lista.
2. Agrega elementos a la lista usando `Add()`.
3. Accede a los elementos de la lista mediante índices o iteración.

   ### -Ejemplo de Saque de Dinero
   
```c#
int saldoTotal = int.Parse(Console.ReadLine());
int valorSaque = int.Parse(Console.ReadLine());

if (saldoTotal >= valorSaque)
{
    int saldo = saldoTotal - valorSaque;
    Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldo}");
}
else
{
    Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
}
```

### -Ejemplo de Lista de Ítems
```c#

List<string> itens = new List<string>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome do item numero - {i + 1}");
    string itemName = Console.ReadLine();
    itens.Add(itemName);
}

Console.WriteLine("Lista de itens:");
foreach (string item in itens)
{
    Console.WriteLine($"- {item}");
}
```
#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso

# Pessoa.cs


- Repositorio GitHub: https://github.com/LdeAlejandro/Net-Fundamentos.git.
- Documento relacionado a la practica: [[Programacion/Net/Cursos/Curso Net Dio/Bootcamp Avanade/Fundamentos Net/Doc Program.cs|Doc Program.cs]]
- Codigo: [[Pessoa.cs]]
#### Descripción

La clase `Pessoa` representa a una persona y contiene información básica como el nombre y la edad. Además, tiene un método para presentar esta información junto con la fecha y hora actuales.

#### Atributos

- `Nome`: Una propiedad de tipo string que almacena el nombre de la persona.
- `Idade`: Una propiedad de tipo entero que almacena la edad de la persona.
- `dataAtual`: Una variable de tipo DateTime que almacena la fecha y hora actuales, con un desplazamiento de 5 días hacia adelante.

#### Métodos

- `Apresentar()`: Un método público que imprime en la consola la presentación de la persona, incluyendo su nombre, edad y la fecha y hora actuales.

#### Uso

1. Instanciar un objeto de tipo `Pessoa`.
2. Asignar valores a las propiedades `Nome` e `Idade`.
3. Invocar el método `Apresentar()` para mostrar la información de la persona en la consola.
#### Consideraciones

- La fecha y hora actuales se obtienen utilizando `DateTime.Now`, y se agrega un desplazamiento de 5 días utilizando `DateTime.AddDays(5)`.
- El método `Apresentar()` imprime la fecha y hora actual formateada como "dd/MM/yyyy HH:mm".

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        DateTime dataAtual = DateTime.Now.AddDays(5);

        public void Apresentar()
        {
            Console.WriteLine($"Óla, meu nome é {Nome}.\nTenho {Idade} anos.\n{dataAtual.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}
```
