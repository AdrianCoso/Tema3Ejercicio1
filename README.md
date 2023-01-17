#Ejercicio 1
En un formulario con título “Mouse Tester” coloca dos botones. Debe actuar de 
la siguiente forma:
• Cada vez que el ratón esté dentro del formulario se debe indicar la 
coordenada en el título (p. ej: x:100, y:212). También debe hacerlo aunque
se esté encima de algún componente. Se debe hacer en una única función 
asociada al evento MouseMove.
• Cuando el puntero está fuera del formulario, se restablece el valor del 
título que había en tiempo de diseño.
• Los botones “emularán” los botones del ratón (izquierdo y derecho) 
cambiando de color si dicho botón del ratón está pulsado sobre el 
formulario imagen. En caso de un ratón con otros botones dicha pulsación 
coloreará los dos Button al mismo tiempo. Este efecto será solo sobre el 
formulario, no es necesario sobre los componentes del mismo.
• Además si se pulsa alguna tecla, dicha tecla debe aparecer como título del
formulario. Si se pulsa ESC, entonces se restaura el título del formulario. 
• Cambia el efecto anterior para que lo que aparezca no sea la tecla, si no el
carácter pulsado. Haz que el uso de este efecto o el del punto anterior se 
puedan selecciona mediante directiva de compilación (#define, #if,...)
Al salir debe preguntar al usuario si está seguro y cancelar en caso negativo.