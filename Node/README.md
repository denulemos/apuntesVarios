# NodeJS - Teoria

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



