# Palabras Reservadas de C#

|          |                        |                        |
|----------------|-----------------------|-----------------------------|
|Abstract|implicit|throw           | 
|As|in|true |
|base|interface|try |
|bool|internal|typeof|
byte|is|uint|
|break|lock|ulong|
|case|long|unchecked|
|catch|namespace|unsafe|
|char|new|ushort|
|checked|null|using|
|class|object|virtual|
|const|operator|volatile|
|continue|out|void|
|decimal|override|while| 
|default|params|
|delegate|private|
|do|protected|
|double|public|
|else|readonly|
|enum|ref|
|event|return|
|explicit|sbyte|
|extern|sealed|
|false|short|
|finally|sizeof|
|fixed|stackalloc|
|float|static|
|for|string|
|foreach|struct|
|goto|switch|
|if|this|


# Solution en C#

Una **"solution"** en C# es un _workspace_ que combina multiples proyectos que usualmente estan relacionados el uno con el otro. Su construcción es bastante útil en situaciones cuando un código se necesita compartir entre esos diversos proyectos. 

Por ejemplo, si estas desarrollando un sitio web con un *__server-side__* distinto o separado, puedes segregarlo en varios proyectos con relación entre ellos:

* Un proyecto que contenga interfaces similares, haciendo un *__DLL__* (biblioteca de enlace dinámico).
* Un proyecto que tenga una base de datos definida, haciendo un script de *__RDBMS__*.
* Un proyecto que implemente un *__server-side API__* para hacer un ejecutable.
* Un proyecto de sitio web, haciendo un script *__IIS__*("Internet Information Services", un servidor web y un conjunto de servicios para el sistema operativo Microsoft Windows). 


