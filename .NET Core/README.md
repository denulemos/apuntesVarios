# Web Api con .NET Core

## Diferencias .NET Core vs .NET Framework
Hoy en dia las paginas tienden al desarollo de paginas con APIS mas que con Razor. .NET Framework empieza antes, y en .NET Core se introduce a la nube y los servicios.

### Framework
* Nacio por el 2001.
* Antes existia ASP.
* Fue una respuesta a Java, fue una competencia.
* Tiene desarollo sobre versiones anteriores, se escribio todo sobre el FW Original.
* Es un paquete que se instala en la PC. 
* Se instalaban mil cosas que no se necesitaban.
* Solo funciona en Windows.
* Solo funciona en Visual Studio como IDE.
* El framework debe estar instalado en el equipo de deploy.
* Enfocado en web (MVC) y escritorio.
* Tiene `packages.xml`, con muchas cosas incluidas en el Scafolding.

### Core
* Se escribio de cero.
* Es open source y modular, se instala por modulos lo que necesito.
* Nació en la era cloud, pensando en performance.
* Es multiplataforma por runtimes hechos para cada SO.
* Ideal para contenedores como Docker.
* Funciona en muchos IDE.
* Se exporta con el entorno de trabajo.
* Enfocado para REST APIs.
* Mejora de Razor -> Blazor, todavia inestable (2020).
* Posee `appsettings.json`, es mas performante.

## ¿Cuando usar cual?

### Framework
* Genera un .dll, de 2mb por lo general.
* Apps en .NET Framework.
* Con librerias framework que no hay hechos en core.
* Con tecnologias que no haya en core.

### Core
* Multiplataforma
* Genera un .dll de 3 kb por lo general, mas liviano.
* Si queres usar Docker, microservicios, varias versiones de .NET en paralelo.
* Si queres un proyecto escalable.
* Si querés exportar todo el entorno de trabajo. 



### .NET Standard
Es para que una sola libreria sea compatible con todos los SDK (Xamarin, Core y Framework), es un standar sobre donde apuntar a los proyectos, esto para mejorar la compatibilidad. Si hago una libreria, que funcione en todos.

**Xamarin** -> Framework para celulares. 

## Estructura Core
* `program.cs` 
  -Todo proyecto wen en NET Core tiene su propio host.

  -Inyecta configuracion del startup.
* `startup.cs`
-Metodo `configureservices`, se agregan los servicios a utilizar (se ejecuta una vez cuando se inicia el proyecto).
-Metodo `configure`, se dan de alta todos los middlewares, en cada peticion se ejecuta.

Se toma el JSON de la variable de entorno, el appSetting de ambiente, pisa al appSettings general.
En launchSettings.json se define la variable de entorno, tambien desde las settings.

## Inyeccion Dependencias
Cada componente toma el control de algunas tasks a medida que se necesitan. **Inversion de control** entre dependencias y clases. 

