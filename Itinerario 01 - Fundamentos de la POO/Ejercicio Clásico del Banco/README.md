# Ejercicio 1

Resuelva el ejercicio y adjunte diagrama de clases y proyecto en Visual Studio.

## User Stories:

Un banco nos ha solicitado una aplicaci�n que permita gestionar las operaciones de las cuentas otorgadas a sus clientes. Las condiciones son las siguientes:

1. La entidad requiere para cada cliente los siguientes datos:
    - **DNI.** Se debe verificar que no est� registrado en otro cliente.
    - **Nombre y apellido.** Verificar que se complete este campo.
    - **N�mero de tel�fono.** Verificar que se complete este campo.
    - **Email para env�o de notificaciones.** Verificar que se complete este campo.
    - **Fecha de Nacimiento.** Para calcular la edad del cliente.
2. El cliente puede solicitar m�s de una cuenta.
3. Cada cuenta solo puede tener asociado un �nico titular (que debe estar registrado como cliente del banco). Adem�s:
    - Cada cuenta posee un c�digo que la identifica y es �nico.
    - Posee un saldo en el cual es posible incorporar dinero mediante una operaci�n de dep�sito o retirar el mismo mediante una extracci�n.
4. El banco ofrece 2 tipos de cuentas:
    - **Caja de ahorro:** El cliente puede realizar extracciones siempre y cuando posea saldo disponible y no supere el importe m�ximo permitido por extracci�n.
    - **Cuenta Corriente:** El cliente puede realizar extracciones siempre y no supere el l�mite de extracci�n en descubierto, es decir que se fija un tope de saldo negativo dentro del cual puede realizar extracciones.

## Operaciones:

1. El programa deber� permitir agregar nuevos clientes, modificar los datos de los clientes existentes y eliminar aquellos que no posean cuentas asignadas.
2. Tambi�n deber� permitir agregar nuevas cuentas, modificar el titular de las mismas o eliminar las cuentas que no posean saldo (saldo igual a cero). Una vez que se define un tipo de cuenta no es posible convertirla a otro tipo disponible (Ej: una caja de ahorro no podr�a convertirse a cuenta corriente).
3. Los usuarios efectuaran en el sistema las operaciones de dep�sito y extracci�n de acuerdo a las caracter�sticas de la cuenta seleccionada:
    - La misma deber� actualizar el saldo de la cuenta de acuerdo a tipo e importe afectado.
    - Se registrar� en el sistema: fecha, tipo de operaci�n e importe afectado.
4. El sistema deber� brindar la siguiente informaci�n: listado de clientes de la entidad (en este listado es posible encontrar un cliente buscando por n�mero de documento o nombre).

---

### Diagrama de Clases del Proyecto

![Diagrama](ClassDiagram.png)

### Requerimientos

1. Requerimiento 1 cumplimentado. **BUG:** Se agrega la verificaci�n para "*DNI: Se debe verificar que no est� registrado en otro cliente*".
2. Requerimiento 2 cumplimentado: ![Captura de pantalla](Requerimiento2.PNG)
3. Requerimiento 3 cumplimentado. **BUG:** Se corrije el t�tulo del InputBox para extracciones: ![Captura de pantalla](Requerimiento3.PNG)
4. Requerimiento 4 cumplimentado.

### Operaciones solicitadas

1. Task 1 cumplimentada: ![Captura de pantalla](Task1.PNG)
2. Task 2 cumplimentada: ![Captura de pantalla](Task2.PNG)
3. Task 3 cumplimentada: ![Captura de pantalla](Task3.PNG)

---

### ToDo

1. Task 4: El Form correspondiente carece de la capacidad de b�squeda de clientes por DNI o nombre.
