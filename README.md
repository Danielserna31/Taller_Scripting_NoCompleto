# Taller_Scripting_NoCompleto


En este taller se busca reforzar patrones de dise�o de software. Cabe recordar que los patrones de dise�o son metodolog�as para mejorar
comunicaci�n, optimizar procesos y mejorar la comunicaci�n de clases para un mejor orden de trabajo en el equipo, por lo tanto se debe
saber que NO existe un c�digo todo poderoso que resuleva los patrones de dise�o. Son conceptos que se pueden plasmar de muchas maneras
en c�digo, por lo tanto pregunte si se siente confundido.

Resumen de los patrones:

Factory: Se le pide a una clase una generaci�n de un tipo de objecto que yo como programa necesito. Para este caso se hace uso de una 
f�brica con piscinas que debe retornar para un enumerado espec�fico. Al ingresarlo la "f�brica" debe saber la referencia del objeto y 
devolerlo de una de las piscinas que est� guardado en �l por medio de un diccionario. Para invocar el ingreso y el regreso de estos 
objetos se debe hacer haciendo uso de la fachada que es RestaurantManager con funciones que tomen un objeto de esa clase y que lo devuelva
una vez se haya terminado su uso

Fachada: La fachada es una clase que se encarga de hacer posibles las funciones de otros sistemas muchos m�s complejos y permite 
organizarlas sin llamar cada operaci�n individualmente. Para nuestro caso la clase es Restaurant Manager y debe encargarse de poder
restar dinero cuando un cliente se vaya, agregar dinero cuando haya una operaci�n exitosa de entrega, reducci�n de recursos y preguntar si
los tiene as� como asignar un cliente a la clase ClienteObj cuando �sta sea instanciada. Tambi�n debe asignar un valor al jugador de qu� 
alimento quiero disparar.

Command: El command es una organizaci�n de clases donde se permite ejecutar una misma funci�n con diferentes tipos de "Inputs", que bien
podr�an ser an�logos como un control o algo que haga operaciones en el juego ("virtual"). Para nuestro caso ser� un mappeo de botones en
pantalla para emular una experiencia prototipada de m�vil. Para ello la clase Command que es la interfaz encargada de que se cumplan las
firmas debe aplicarse para los dos tipos de command (Boton y teclado). Para asegurarse de que funcione se implementa el bot�n de Switch
que intercambiar� el tipo de input deseado para que ejecute las acciones del jugador. La clase que se encarga de comunicarlo es la de 
PlayerController.

Anexo UML tentativo del proyecto:
https://www.lucidchart.com/documents/view/068fbab5-4759-43a7-9109-9c3ca1b7fb65/0

Recuerde que puede hacer los ajustes cambios y adaptaciones que sean necesarios para la funcionalidad completa del proyecto. Puede agregar
tantas clases y funcionalidades como crea que sean necesarias.