**Código y Nombre del CASO  DE  USO:** CU-003 - Recuperar contraseña

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Reiniciar contraseña de usuario a travez de validación de correo.

**ACTORES** 

**Primario:** Usuario

**Iniciador:** Usuario

**Otros:** <vacío>

**PRECONDICIONES (de negocio):** --

**PRECONDICIONES (de sistema):** Existe usuario.

**DISPARADOR:** Usuario olvida su contraseña al iniciar sesión y apreta en "Olvidé mi contraseña".

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Sistema muestra formulario.
   - Usuario.
   - Correo.
2. Usuario completa Usuario y Contraseña y apreta "Enviar correo de recuperación".
5. Sistema valida usuario y correo.
6. Sistema envia correo e informa al usuario.
7. Usuario ingresa en el link enviado.
8. Sistema muestra formulario.
   - Contraseña nueva.
   - Validar contraseña.
9. Usuario completa campos y apreta en "Confirmar".
10. Sistema valida que ambos campos sean iguales.
11. Sistema actualiza contraseña de usuario.
12. Sistema muestra pantalla de inicio de seción.
13. Fin CU.

**CAMINOS ALTERNATIVOS:**

5.**\<Durante\>** No existe coincidencia Usuario-Correo.\
&nbsp;&nbsp;&nbsp;&nbsp;5.a.1 Notifica al usuario. Vuelve al paso 1.\
7.**\<Previo\>** Pasan 7 días desde pedido de reinicio y no se efectúa el cambio. [RN-012](./reglas-de-negocio.md/#12)\
&nbsp;&nbsp;&nbsp;&nbsp;7.a.1 Sistema da de baja pedido de cambio de contraseña. Fin CU. [RN-013](./reglas-de-negocio.md/#13)\
7.**\<Previo\>** Usuario inicia sesión normalmente.\
&nbsp;&nbsp;&nbsp;&nbsp;7.b.1 Sistema da de baja pedido de cambio de contraseña. Fin CU.\
10.**\<Posterior\>** Los campos no son iguales.\
&nbsp;&nbsp;&nbsp;&nbsp;10.a.1  Notifica al usuario. Vuelve al paso 8.\
10.**\<Previo\>** Usuario sale del sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;10.b.1 Fin CU.
    
**POSTCONDICIONES (de sistema):**

**Éxito:** Contraseña actualizada.

**Éxito alternativo:**

**Fracaso:** Sin cambios en contraseña
