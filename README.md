# INF512-Unidad1-POO
Proyecto de la Unidad 1 sobre Programación Orientada a Objetos utilizando C#.

Descripción del proyecto

Este repositorio corresponde a la actividad práctica de la Unidad 1 de la asignatura INF512. El proyecto tiene como finalidad aplicar conceptos básicos de la Programación Orientada a Objetos (POO) mediante un ejemplo desarrollado en el lenguaje C#.

Objetivo

El objetivo de este proyecto es poner en práctica algunos de los conceptos fundamentales de la Programación Orientada a Objetos, como:

* Clases
* Objetos
* Atributos
* Métodos
* Estado
* Comportamiento
* Encapsulamiento

Ejemplo utilizado

Para demostrar estos conceptos se creó una clase llamada `Producto`, que representa un producto dentro de un sistema sencillo de inventario.

La clase contiene los siguientes atributos:

`nombre`: almacena el nombre del producto.
  `precio`: almacena el precio del producto.
 `cantidad`: indica cuántas unidades del producto están disponibles.

También contiene métodos que representan el comportamiento del producto:

`Vender()`: permite disminuir la cantidad disponible cuando se realiza una venta válida.
`Reponer()`: permite aumentar la cantidad disponible.
`MostrarInformacion()`: muestra la información actual del producto.

 POO aplicada

En el proyecto se utiliza el encapsulamiento mediante atributos privados. De esta manera, los datos internos del objeto no pueden modificarse directamente desde cualquier parte del programa y los cambios se realizan mediante los métodos correspondientes.

El estado del objeto está representado por los valores actuales de sus atributos, mientras que su comportamiento está representado por las acciones que puede realizar mediante sus métodos.

Archivos del proyecto

`README.md`: contiene la descripción y documentación del proyecto.
  `Producto.cs`: contiene la clase `Producto`, sus atributos, constructor y métodos.

Control de versiones

Durante la realización de esta actividad se utiliza GitHub como plataforma para almacenar el proyecto y llevar un registro de los cambios realizados.

Se realizarán como mínimo tres commits con mensajes descriptivos para demostrar el proceso de desarrollo del proyecto.

Autor

Estudiante de INF512

Unidad

Unidad 1 - Conceptos básicos de Programación Orientada a Objetos
