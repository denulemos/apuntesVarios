# React 🚀️

## ¿Qué es el desarrollo Front-End?

Se refiere al desarrollo de lo que el usuario final (cliente) va a ver. Consiste, básicamente, en HTML, CSS y JS. Como desarrolladores, somos consientes que a medida que las paginas van creciendo, se van haciendo cada vez mas complejas, y para manejar estas necesidades, se crearon librerías como React.

React fue creada por Facebook en 2013.

## ¿Porque React?

**Velocidad** 

Las web interactivas necesitan actualizar el DOM casi siempre cada vez que cambia algo, React usa un **DOM Virtual** que permite hacer el update solo en las partes de la web que son necesarias. Esto aumenta mucho la velocidad de actualización.

**Fácil de usar**

Hace que mantener aplicaciones complejas sea mucho mas fácil.

**Support**

Hay mucha comunidad atrás de este lenguaje. Esta mantenido por Facebook y su comunidad. 

# Getting Started

## Agregar React al HTML

Primero, tenemos que agregar a React en la etiqueta `<head>` de nuestro HTML. 

```html
<script src="https://unpkg.com/react@16/umd/react.development.js" crossorigin></script>

 <script src="https://unpkg.com/react-dom@16/umd/react-dom.development.js" crossorigin></script> 
```

También tenemos que agregar otro Script para permitir el **uso de JSX** , esta es una extensión de JS. 

```html
<script src="https://unpkg.com/babel-standalone@6/babel.min.js"></script> 
```

Creamos el container `<div id="container"></div>` y mostramos el primer mensaje hecho con React

```javascript
<script type="text/babel">
ReactDOM.render(
  <h1>Hello, React!</h1>,
  document.getElementById('container')
) 
</script>
```

Este Script busca el div con el ID 'Container' y le agrega el `<h1>`

## Crear una Aplicación React

En este caso, vamos a necesitar Node para crear un proyecto React. Vamos a crear una aplicación llamada "my-app"

```
npx create-react-app my-app
cd my-app
npm start 
```

