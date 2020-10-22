# Introduccion a Hacking

El hacking es basicamente explotar las vulnerabilidades de un sistema. El hacking no siempre es malo, ya que varias veces ayuda a descubrir baches de seguridad en sostemas grandes, lo cual lleva al **Ethical Hacking**.

### Security Basics

Segun la mente de un hacker, todo posee alguna debilidad o vulnerabilidad.

* **Black-hat hacker** -> Es un hacker que basa sus conocimiento para fines maliciosos, como robo de informacion, etc..
* **White-hat hacker** -> Es basicamente alguien que hace hacking etico, hackea a un sistema para avisarle al dueño que el mismo posee vulnerabilidades.

## Cryptography

Es la ciencia de escribir en "codigo secreto", usando herramientas para que un tecto ilegible tenga sentido. Es reemplazar una letra por otra, o una palabra por algo. Un ejemplo puede ser el **Caesar Cipher**, que posee la siguiente logica ->

```
a-b-c-d-e-f-g-h-i-j-k-l-m-n-o-p...

b-c-d-e-f-g-h-i-j-k-l-m-n-o-p-q

Ju xbt Hsffl up nf -> It was Greek to me
```

Otro es **Atbash Cipher** ->

```
a-b-c-d-e-f-g-h-i-j-k-l-m-n-o-p...   

z-y-x-w-v-u-t-s-r-q-p-o-n-m-l-k...
Gsild z yzhs --> Throw a bash
```

Tambien esta el **Polybius Square** que reemplaza letras por numeros ->

```
| 1  2  3  4  5  

--+---------------- 

1 | A  B  C  D  E  

2 | F  G  H I/J K  

3 | L  M  N  O  P  

4 | Q  R  S  T  U  

5 | V  W  X  Y  Z
```

El **Rail Fence Cipher** pone las letras en distintos rieles para que se lea de la siguiente manera ->

```
L...S...K

.E.U.H.C.

..T..A..

“Let us hack”
```

 Para contraseñas tenemos el hash encription que convierte cualquier palabra a una cadena de 32 caracteres, sin importar el largo de la palabra. Esto es util, ya que nos ayuda a comparar 2 input, saber sí son el mismo, sin siquiera saber cual es el input en cuestion, ya que para la misma palabra el output es el mismo.

Gracias al efecto avalancha, un solo cambio en una palabra puede dar a un hash completamente distinto de otro, aunque la diferencia sea minima, resultando irreconocible uno del otro.

De esto hay 2 tipos, SHA-1 y MD5, varian en el largo del output y en el proceso de encriptacion, por ejemplo SHA es de 40 caracteres, en MD5 en cambio se descubrieron muchas vulnerabilidades, lo cual hace que sea poco recomendado usarlo.

**enciphering** --> Transformar texto plano en texto oculto

### Passwords

Una manera de hackear una contraseña es usando un archivo diccionario que posee todas las contraseñas más comunes, y de forma automatizada, las prueba. Una manera de evitar esto, es

* Limitando la cantidad de intentos de contraseñas
* Agregando un CAPCHA

### SQL Injection

Es un ataque de website muy comun, ya que con este podemos exponer la base de datos de una pagina.

* Muchos sitios usan bases de datos
* Hay muchisimos scripts que automatizan este tipo de ataques
  
  Con este ataque podemos correr comandos en las bases de datos de una pagina, convirtiendonos automaticamente en administradores de la misma, pudiendo acceder a datos sensibles.
  
  Usualmente se usan input fields para inyectar codigo SQL, también campos de login, por ejemplo

```
Username:' OR '1'='1
Nos devuelve => SELECT * FROM users WHERE username = '' OR '1'='1'
```
 Esto nos va a dar un resultado que el website no espera. ¿Como evitamos este ataque?

* Asegurandonos que los input de los sitios no contengan ciertos simbolos
* Usando expresiones comunes para validar la informacion
* Rechazando espacios en blanco en el input
* Parametrizando el SQL, estos son placeholders y aseguran que el input sea usado de manera segura

```
SELECT * FROM users WHERE username = @USERNAME
```

### Session Hijacking

Siempre que entramos a una web, el server y el navegador intercambian algo llamado session ID para identificar la visita. ¿Como evitamos un ataque desde este lado? haciendo un session ID largo, random y único, ya que un ID debil puede hacer que una persona acceda a los datos de otra persona sin necesidad de identificarse antes, y esto puede ser logrado a través de un Script, el cual enumera IDs comunes y los testea uno por uno.

```
Trying 87326521 - HTTP 500 ERR

Trying 87326522 - HTTP 404 MISSING

Trying 87326523 - HTTP 301 MOVED

Trying 87326524 - HTTP 200 OK //Siendo este correcto

Trying 87326525 - HTTP 403 FORBID
```

Otra manera de cuidarse de este metodo, es usando web frameworks, para que se creen fuertes session ID..

* Previenen el reuso de Sessions ID
* Desactivan esos session ID despues de 20 minutos
* Cambian de session ID luego de cada request
* Algunos linkean los Session ID con las Cookies, ya que estan contienen la data de la sesion actual, esto se hace con un sign a la cookie con codigo encriptado.

### Path Transversal

Este maneja el manejo incorrecto de nombres de archivos con informacion sensible en la url de un website, todo esto para acceder a archivos que no estaban hechos para mostrarse en navegador.

```
domain.com/?file=../passwords.txt
```

También se le dice “dot dot slash attack” ya que el doble punto .. recorre los directorios del server.

```
xcorp.com/?get=../../../staff.csv
```

Una manera de evitar este ataque se deben guardar los archivos sensibles en distintas locaciones en el server, una particion segura del mismo server u otro server. Esto también se puede evitar restringiendo los permisos en el server.

### Hackeando un Website

**Scanning Phase **, se entra a la web y se trata de recopilar la mayor cantidad de informacion posible

1. Sí la web posee un log in, ya tenemos un spot visto, los input, en donde se pueden meter querys. Siempre es recomendable entrar primero con un user valido, para poder seguir viendo de que se trata la web.
2. Ver los posibles errores que la web tira en el DevTools, en la consola.

Algo que se puede intentar, es meter un ‘ en los input de la pagina. Sí nos tira un error 500 internal server error, ahi tenemos una pista, ¿Porque pasa esto?, en nuestro input, tenemos la siguiente Query

```
SELECT *

FROM users

WHERE email = 'INPUT';
```

Sí a la query, en vez de INPUT le mandamos un texto con un apostrofe de más, quedaria como WHERE email = ‘ejemplo’’ dando un error de sintaxis. Otra cosa con la que se puede jugar es ingresando X’ OR ‘1’ = ‘1’, evaluando una condicion siempre como verdad

```
SELECT *

FROM users

WHERE email = 'x' OR '1' = '1';
```

Como no sabemos los nombres de los campos que posee la base de datos, una forma de averiguarlo, es ingresando X’ AND email IS NULL; --’  agregando el punto y coma, y el doble guion al final, y sí nos vuelve a tirar un error 500, es porque la tabla no tenia el nombre de “email”, sí obtenemos un error del tipo couldn´t find user es porque le pegamos al nombre, ya que devolvera falso en ambos casos, tanto en el usuario como en la tabla, ya que no es NULL.

Podemos intentar cambiar el email de un user por el nuestro así podemos resetear la password. Podemos ir a la zona de “Reset Passwod” de la pagina deseada y escribir la siguiente query

```
x'; UPDATE users SET email_address = 'me@me.com' WHERE email_address = 'h4x0r@dark.net
```

Haciendo que el server ejecute lo siguiente..

```
UPDATE users

SET email_address = 'me@me.com'

WHERE email_address = 'h4x0r@dark.net';
```

### Man in the Middle Attack

Este ataque ocurre cuando “escuchamos” las comunicaciones que hay entre la gente y el website, esto se previene con una esncriptacion HTTPS. Nosotros podemos “escuchar” a una web de manera remota y sin detectar, alterando el trafico web, todo esto mediante..

Haciendo nuestras propias redes wifi hotspot inseguras para que la gente se conecte. Por ejemplo, ir a un café y poniendo un nombre tipo “wifi-café” para que parezca confiable, a esto se le dice evil twin attack. Una vez que ya instalamos el evil twin a una red pública, podemos tener acceso al siguiente flujo de datos

```
tls-http:443 - GET bank.com

tls-http:443 - POST bank.com

tcp-http:80 - GET xcorp.com

tcp-http:80 - POST xcorp.com
```
Podemos ver en el http:80 que hay información sin encriptar yendo hacia el xcorp.com. Esto puede tratarse de alguna contraseña.

Cómo identificar a un evil twin?
-Se desconecta seguido
-Tiene una locación rara
-Promete rapidez en el internet
-Malwares instalados en PC ajenas
-Usando un sniffer para meternos en el flujo web, ver las request sin encriptar y para detectar vulnerabilidades de la red, y explotarlas

### Social Engineering

 Es el engañar a las personas para que den datos personales, puede ser mediante el Pretexting que es el elaborar un escenario para engañar a las personas, para esto se requiere una investigacion previa a la persona. Esto puede ser mediante Pishing, que es fingir ser otra persona de autoridad para obtener informacion relacionada, como una entidad bancaria.

Vishing es el pishing telefonico, usualmente funciona con grabaciones pre hechas que le piden al usuario diversa informacion mediante telefono






