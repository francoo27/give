**Código y Nombre del CASO  DE  USO:** CU-004 - Donación a suscripción

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Usuario dona en suscripción.

**ACTORES** 

**Primario:** Usuario donante

**Iniciador:** Usuario donante

**Otros:** Checkout API

**PRECONDICIONES (de sistema):**
1. Existe usuario.
2. Existe suscripción.
3. Suscripción está activa.

**DISPARADOR:** Usuario entra en lista de campañas activas.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Persona entra a la plataforma y elige la opción "Contribuir".
2. Sistema lista de campañas/suscripciones y panel de filtros:
   - Lista de campañas/suscripciones/Solicitantes:
        - Imágen.
        - Nombre.
        - Descripción.
        - Checks de validaciones.
   - Panel de filtros:
        - Campaña/Suscripción.
        - Tipo de campaña.
        - Categoría.
        - Porcentaje de cumplimiento.
        - Ordenar por (↑/↓):
             - Porcentaje de cumplimiento.
             - Fecha de fin.
             - Dinero invertido.
             - Monto requerido.
             - .
4. Usuario selecciona filtros.
5. Sistema filtra listado según parámetros elegidos.
6. Usuario elige suscripción.
7. Sistema abre suscripción y muestra información relacionada.
8. Usuario elije "Contribuir".
9. Sistema muestra formulario:
    - Donación única/ Donación periódica. (Botón de altenancia).
    - Monto. (Cuadro de texto).
10. Usuario coloca monto y presiona "Continuar".
11. Sistema muestra formulario de métodos de pago.
    - Métodos de pago guardados. (Lista de opciones guardadas).
    - Agregar nuevo método de pago.
12. Usuario elige método de pago guardado.
13. Sistema muestra formulario de confirmación.
    - Campaña.
    - Monto.
    - Método de pago.
    - Código de confirmación (Campo de tecto).
14. Usuario coloca código de seguridad y apreta "Pagar".
15. Sistema envía orden de pago a Checkout API.
    - Monto.
    - Cuenta origen.
    - Cuenta destino.
17. Checkout API valida datos de mátodo de pago. Realiza transacción y envía confirmación.
18. Sistema muestra confirmación de pago.
19. Fin CU.

**CAMINOS ALTERNATIVOS:**

1.**\<En lugar de\>** Persona busca suscripción por nombre en buscador.\
&nbsp;&nbsp;&nbsp;&nbsp;1.a Sistema muestra listado de suscripción con coincidencias de nombre. Continúa paso 4 o 5.\
9.**\<Posterior\>** Usuario elige Contribución periódica.\
&nbsp;&nbsp;&nbsp;&nbsp;9.a.1 Sistema muestra cuadro de texto "Periodo" y "Día de pago".\
&nbsp;&nbsp;&nbsp;&nbsp;9.a.2 Usuario completa monto y periodo y día de pago. Continúa paso 11.\
12.**\<En lugar de\>** Usuario elige "Nuevo método de pago".\
&nbsp;&nbsp;&nbsp;&nbsp;12.a Inicia CU-xxx. Vuelve a paso 12.\
14.**\<En lugar de\>** Usuario elige "Cancelar".\
&nbsp;&nbsp;&nbsp;&nbsp;12.a Vuelve a paso 11.\
14.**\<Previo\>** Persona sale del sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;14.b.1 Fin CU.
16.**\<En lugar de\>** Checkout API no valida código de seguridad.\
&nbsp;&nbsp;&nbsp;&nbsp;16.a Checkout API envía mensaje a Sistema.
&nbsp;&nbsp;&nbsp;&nbsp;16.a Sistema notifica a usuario. Vuelve a paso 13.\
18.**\<Previo\>** Usuario eligió contribución periódica.\
&nbsp;&nbsp;&nbsp;&nbsp;7.a Sistema registra periodicidad de pego.\
&nbsp;&nbsp;&nbsp;&nbsp;7.a Sistema muestra confirmación de pago y de registro de periodicidad.\

**POSTCONDICIONES (de sistema):**

**Éxito:** Se realiza contribución única a suscripción.

**Éxito alternativo:** Se realiza contribución periódica a suscripción.

**Fracaso:** No se realiza contribución, ni registro de periodicidad de pago.
<hr>

[Volver a README](../README.md)
