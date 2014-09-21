#Lenguajes De Dominio Específico Para El Desarrollo De Pruebas Automatizadas

## Cómo ejecutar el ejemplo

Este proyecto fue creado en Visual Studio 2012 (también funciona con Visual Studio 2013).

### Paso 1: Ejecutar el sitio de pruebas
Establecemos como proyecto inicial el sitio web:
![](http://i.imgur.com/tMX4GTD.png "Paso 1")

### Paso 2: Desacoplar depurador 
A continuación desacoplamos el depurador:

![](http://i.imgur.com/JGFrzBT.png "Paso 2")

y podemos ver que el sitio está activo en IIS Express:
![](http://i.imgur.com/9I7sHta.png "IIS Express")
<img src="http://i.imgur.com/7x8Nxlz.png" alt="Pagina para pruebas" style="width:450;height:350">

### Paso 3: Seleccionar proyecto de pruebas

Establecemos el proyecto de pruebas como el proyecto de inicio:
![](http://i.imgur.com/yHDErxP.png "Paso 3")

### Paso 4: Ejecutar la prueba

Una vez completado este paso podemos ejecutar la prueba por medio de ReSharper, CodeRush, TestDriven.NET u otro Plug-in para ejecutar pruebas, en caso de no contar con ninguno de estos, podemos correr la aplicación y la prueba se ejecuta automáticamente:

<img src="http://i.imgur.com/7J6ZraK.png" alt="Paso 4" style="width:450;height:350">

## Herramientas usadas

* [FluentAutomation](https://github.com/stirno/FluentAutomation
)

	FluentAutomation es un potente framework de pruebas simple,  para automatizae aplicaciones web. Puede ser utilizado con Selenium WebDriver o WatiN para probar todo tipo de navegadores y dispositivos.
	
* [XUnit.Net](https://github.com/xunit/xunit)

	xUnit.net es una herramienta de pruebas de unitarias de codigo abierto, escrito por el creador original de NUnit v2; este framework permite crear pruebas unitarias en C #, F #, VB.NET y otras lenguajes para .NET. 
