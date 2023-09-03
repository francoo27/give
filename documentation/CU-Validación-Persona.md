**Código y Nombre del CASO  DE  USO:** CU-004 - Validación de identidad

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Validar identidad de persona física o jurídica de usuario.

**ACTORES** 

**Primario:** Usuario

**Iniciador:** Usuario

**Otros:** SID Renaper.

**PRECONDICIONES (de negocio):** --

**PRECONDICIONES (de sistema):** Existe usuario.

**DISPARADOR:** Usuario decide validar su identidad para poder hacer uso de más funciones de Give.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Persona entra a la plataforma y elige la opción "Iniciar seción".
2. Sistema muestra formulario de creación de usuario:
   - Usuario.
   - Contraseña.\
     y
     - "Olvidé mi contraseña"
     - "O unirse con Facebook/Google".
3. Usuario completa Usuario y Contraseña y apreta "Entrar".
4. Sistema valida usuario y contraseña.
6. Sistema muestra página de inicio de Give.
7. Fin CU.

**CAMINOS ALTERNATIVOS:**

3.**\<En lugar de\>** Persona elige "O unirse con Facebook/Google".\
&nbsp;&nbsp;&nbsp;&nbsp;3.a.1 Fin CU. Iniciar CU-00x.\
*¿Lo ponemos acá o hacemos un CU explusivo para los logueos por otro medios?*\
   *Cualquiera sea el caso, si ya se ha logueado anteriormente con otro medio, debería saltar al iniciar sesión*\
3.**\<En lugar de\>** Persona elige "Olvidé mi contraseña".\
&nbsp;&nbsp;&nbsp;&nbsp;3.b.1 Fin CU. Iniciar CU-00x.\
4.**\<Durante\>** No existe coincidencia Usuario-Contraseña.\
&nbsp;&nbsp;&nbsp;&nbsp;4.a.1 Notifica a la persona. Vuelve al paso 2.\
4.**\<Previo\>** Persona sale del sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;4.b.1 Fin CU.
    
**POSTCONDICIONES (de sistema):**

**Éxito:** Sesión activa.

**Éxito alternativo:** Sesión activa mediante usuario enlazado a otro medio.

**Fracaso:** No se inicia sesión.
