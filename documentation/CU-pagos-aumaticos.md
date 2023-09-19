**Código y Nombre del CASO  DE  USO:** CU-004 - Pago automático

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Sistema realiza pagos registrados como periódicos para el día de la fecha.

**ACTORES** 

**Primario:** Sistema

**Iniciador:** Sistema

**Otros:** Checkout API

**PRECONDICIONES (de sistema):**
1. Existe usuario.
2. Existe suscripción.
3. Suscripción está activa.
4. Existen pagos periódicos registrados.
5. Existe método de pago registrado.

**DISPARADOR:** Sistema diariamente busca pagos periódicos registrados para el día actual.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Sistema busca pagos periódicos donde el día coincida con el actual.
2. Para cada pago periódico registrado:
    1. Sistema envía ordenes de pago a Checkout API.
        - Monto.
        - Cuenta origen.
        - Cuenta destino.
    2. Checkout API valida datos de método de pago.
    3. Realiza transacción y envía confirmación.
    4. Sistema envía confirmación de pago a usuario. Y actualiza monto total recibido en campaña/suscripción.
3. Fin CU.

**CAMINOS ALTERNATIVOS:**

2.**\<Previo\>** Sistema no encuentra pagós periódicos para el día de la fecha.\
&nbsp;&nbsp;&nbsp;&nbsp;2.a.1 Fin CU.\
2.ii.**\<En lugar de\>** Checkout API no valida método de pago.\
&nbsp;&nbsp;&nbsp;&nbsp;2.ii.a.1 Checkout API envía mensaje a Sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;2.ii.a.2 Sistema envía notificación al usuario y da de baja pago periódico.\
&nbsp;&nbsp;&nbsp;&nbsp;2.ii.a.3 Fin CU.\
2.iii.**\<En lugar de\>** Checkout API no valida fondos suficientes.\
&nbsp;&nbsp;&nbsp;&nbsp;2.iii.a.1 Checkout API envía mensaje a Sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;2.iii.a.2 Sistema envía notificación al usuario y actualiza fecha de pago para 3 días en el futuro.\
&nbsp;&nbsp;&nbsp;&nbsp;2.iii.a.3 Fin CU.\
2.iii.**\<En lugar de\>** Checkout API no valida fondos suficiente (5 intento).\
&nbsp;&nbsp;&nbsp;&nbsp;2.iii.b.1 Checkout API envía mensaje a Sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;2.iii.b.2 Sistema envía notificación al usuario.\
&nbsp;&nbsp;&nbsp;&nbsp;2.iii.b.3 Fin CU.\

**POSTCONDICIONES (de sistema):**

**Éxito:** Se realizan contribuciónes periódicas o no hay cambios en el sistema.

**Éxito alternativo:** Se realiza contribución periódica a suscripción.

**Fracaso:** Se actualizan fechas de pago o hay 5 intentos fallidos de pago.
