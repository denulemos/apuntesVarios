# NodeJS - Teoria

## Manejo de Archivos - Asincronico



## Administradores de paquetes (Package Manager)

Los package manager sirven para no tener que descargar, instalar y mantener las dependencias de un proyecto. Facilitan la descarga e instalacion de librerias del proyecto. Para esto se necesita saber el nombre del paquete, y a veces version del mismo. Con solo ejecutar un comando, se descargará un repositorio con la version correspondiente y se agregará al proyecto.
NodeJS cuenta con su propio administrador de paquetes **NPM (NodeJS Package Manager)**

### Instalando dependencias con NPM

Las dependencias pueden instalarse de forma global o local.

* Forma global -> `npm i -g nombre-paquete` Es posible que se nos pidan permiso de administrador ya que estamos agregando contenido a las carpetas del sistema.
* Forma local -> `npm i nombre-paquete`

Si instalamos la libreria de forma global, todos los programas tendran esa libreria con una misma version. Si no, conviene instalarlo de manera local, para evitar problemas de versiones.
Es util instalar de manera global **librerias utilitarias**.

### Archivo package.json

Los proyectos de NodeJS cuentan con un archivo de configuracion en formato JSON que nos permite especificar el nombre del proyecto, versiones, etc.. El archivo posee la lista de dependencias, es una lista con los nombres de las librerias con su respectiva version. Tambien se pueden incluir dependencias "dev", que son para ser usadas para probar cosas durante el desarollo.

Para iniciar un proyecto node ->  `npm init` nos hará un par de preguntas y nos armará un archivo con todo lo necesario. Nos pedira nombre, version, descripcion, archivo de entry point, test command, git repo, keywords, autor y licencia.

Con el init, se generará el siguiente archivo (o parecido)

```
{
"name": "proyecto",
"version": "1.0.0",
"descripcion" : "es un proyecto",
"main": "index.js",
"scripts":{
"test": "No hay tests",
},
"author": "denisse",
"license" : "ISC",
"keywords": []
}
```

Si no quiero responder todo el cuestionario y generar un proyecto generico -> `npm init --yes`

### Manejo automatizado de dependencias

Con solo ejecutar un comando, podremos obtener las dependencias del proyecto, siempre y cuando esten en package.json -> `npm install` o `npm i`, esto para instalar y/o actualizar las dependencias.

### Versionado

Las librerias de NPM tienen una cierta semantica de versionado. Son 3 numeros:

* El primer numero son grandes actualizaciones (**Major Release**)
* El segundo numero son cambios pequeños o menores (**Minor Release**)
* El tercer numero corresponde a Parches (**Patches**) que corrigen bugs.

Ejemplo del archivo package.json con dependencias ->

```
{
"name" : "proyecto",
"version": "1.0.0",
"description" : "",
"main":"index.js",
"scripts":{
"test": "echo \"Error: no test"\" && exit 1"
},
"author": "",
"license" : "ISC",
"dependencies": {
"express" : "^4.16.4",
"joi": "~14.3.1",
"sleep": "*1.2.0"
},
"devDependencies":{
"jest" : "latest"
}
}
```

Podemos ver que cada version tiene un simbolito, el mismo indica como se va a actualizar la dependencia con cada `npm install`.

* ~ Solo parches
* ^ Solo actualizaciones menores y parches
* (*) Todas las actualizaciones
* (>) Actualizar a cualquier version posterior a la dada
* (>=) Igual o posterior a la dada

Si no se pone ningun simbolo, se acepta solo la version especificada.

### Puntos de inicio del proyecto

Dentro del package.json hay un objeto `scripts` que nos permitirá definir comandos personalizados para ejecutar el proyecto desde distintos puntos de entrada.

```
{
...
"scripts":{
"start" : "node src/main.js",
"test" : "node test/testAll.js",
"empezar" : "node src/main.js"
}

}
```

Encontamos definidos dos puntos de inicio para nuestro programa, uno iniciará el servidor y otro va a ejecutar los tests. Entonces, cuando corremos un `npm start` estariamos corriendo el comando que le sigue. Tambien podemos definir nuestros propios comandos como "empezar", pero en ese caso, tendriamos que hacer un `npm run empezar`.

