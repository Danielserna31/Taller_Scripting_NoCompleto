# Taller_Scripting_NoCompleto


En este taller se busca reforzar patrones de diseño de software. Cabe recordar que los patrones de diseño son metodologías para mejorar
comunicación, optimizar procesos y mejorar la comunicación de clases para un mejor orden de trabajo en el equipo, por lo tanto se debe
saber que NO existe un código todo poderoso que resuleva los patrones de diseño. Son conceptos que se pueden plasmar de muchas maneras
en código, por lo tanto pregunte si se siente confundido.

Resumen de los patrones:

Factory: Se le pide a una clase una generación de un tipo de objecto que yo como programa necesito. Para este caso se hace uso de una 
fábrica con piscinas que debe retornar para un enumerado específico. Al ingresarlo la "fábrica" debe saber la referencia del objeto y 
devolerlo de una de las piscinas que está guardado en él por medio de un diccionario. Para invocar el ingreso y el regreso de estos 
objetos se debe hacer haciendo uso de la fachada que es RestaurantManager con funciones que tomen un objeto de esa clase y que lo devuelva
una vez se haya terminado su uso

Fachada: La fachada es una clase que se encarga de hacer posibles las funciones de otros sistemas muchos más complejos y permite 
organizarlas sin llamar cada operación individualmente. Para nuestro caso la clase es Restaurant Manager y debe encargarse de poder
restar dinero cuando un cliente se vaya, agregar dinero cuando haya una operación exitosa de entrega, reducción de recursos y preguntar si
los tiene así como asignar un cliente a la clase ClienteObj cuando ésta sea instanciada. También debe asignar un valor al jugador de qué 
alimento quiero disparar.

Command: El command es una organización de clases donde se permite ejecutar una misma función con diferentes tipos de "Inputs", que bien
podrían ser análogos como un control o algo que haga operaciones en el juego ("virtual"). Para nuestro caso será un mappeo de botones en
pantalla para emular una experiencia prototipada de móvil. Para ello la clase Command que es la interfaz encargada de que se cumplan las
firmas debe aplicarse para los dos tipos de command (Boton y teclado). Para asegurarse de que funcione se implementa el botón de Switch
que intercambiará el tipo de input deseado para que ejecute las acciones del jugador. La clase que se encarga de comunicarlo es la de 
PlayerController.

Anexo UML tentativo del proyecto:
https://www.lucidchart.com/documents/view/068fbab5-4759-43a7-9109-9c3ca1b7fb65/0

Recuerde que puede hacer los ajustes cambios y adaptaciones que sean necesarios para la funcionalidad completa del proyecto. Puede agregar
tantas clases y funcionalidades como crea que sean necesarias.