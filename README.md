1) ¿String es un tipo por valor o un tipo por referencia?
Es un tipo por referencia

2) ¿Que secuencias de escape tiene el tipo string?
El tipo string en c# admite varias secuencias de escape, que son caracteres especiales utilizados para representar caracteres no imprimibles o caracteres que tienen un significado especial en una cadena.Secuencias de escape mas comunes: ": Comilla doble. ': Comilla simple. : Barra invertida. \0: Caracter nulo. \a: Caracter de alarma (bip). \b: Retroceso. \f: Salto de pagina. \n: Salto de linea. \r: Retorno de carro. \t: Tabulacion hotizontal. \v: Tabulacion vertical.

3) ¿Que sucede cuando utiliza el caracter @ y $ antes de una cadena de texto? 
La notacion @ antes de una cadena de texto permite que la cadena se interprete literalmente, lo que significa que los caracteres de escape (como \n o \t) no seran procesados y se consideraran como caracteres normales dentro de la cadena. Esto puede ser util cuando se trabaja con cadenas de texto que contienen rutas de archivo, expresiones regulares u otros casos en los que se desea evitar las necesidad de escribir dobles barras invertidas () \ para representar una barra invertida en la cadena. El caracter $ antes de una cadena de texto en c# indica que la cadena es una cadena de texto interpolada, tambien conocida como interpolaacion de cadenas. La interpolacion de cadenas permite incrustar expresiones dentro de una cadena utilizando la sintaxis '${expression}'. Las expresiones se evaluan en tiempo de ejecucion y se sustituyen por su valor correspondiente dentro de la cadena.

++Ejercicios Adicionales  
1) ¿Qué son las expresiones regulares?
Las expresiones regulares (regex) son patrones de búsqueda utilizados para encontrar, extraer o manipular texto basado en ciertas reglas. Funcionan como un lenguaje miniaturizado para describir patrones en cadenas de texto.

2) ¿Funcionan únicamente en C#?
No, las expresiones regulares son un concepto universal en programación y están disponibles en casi todos los lenguajes modernos como Java, Python, JavaScript, PHP, Perl, etc. Cada lenguaje tiene su propia implementación pero la sintaxis básica es similar.

3) Casos útiles (3 ejemplos):
Validación de formatos: Verificar si un correo electrónico, número de teléfono o documento tiene el formato correcto.

Búsqueda y extracción de datos: Encontrar todas las fechas, códigos o patrones específicos en un texto grande.

Limpieza y transformación de datos: Reemplazar formatos inconsistentes, eliminar caracteres no deseados o reformatear información.