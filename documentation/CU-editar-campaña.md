**Código y Nombre del CASO  DE  USO:** CU-004 - Donación

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Usuario dona en campaña.

**ACTORES** 

**Primario:** Usuario donante

**Iniciador:** Usuario donante

**Otros:** <vacío>

**PRECONDICIONES (de sistema):**
1. Existe usuario.
2. Existe campaña.
3. Campaña está activa.

**DISPARADOR:** Usuario entra en lista de campañas activas.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Persona entra a la plataforma y elige la opción "Unirse a Give".
2. Sistema muestra formulario de creación de usuario:
   - Cuenta personal/Cuenta empresarial.
   - Usuario.
   - Contraseña.
   - Correo.
   - Nombre/Razón social. (OPCIONAL)
   - Apellido. (OPCIONAL)
   - Dni. (OPCIONAL)
   - "Para evitar fraudes, ciertos datos son necesarios para poder realizar todas las funciones de Give, leer más aquí"
4. Usuario completa información y apreta "Crear usuario".
5. Sistema valida inexistencia de usuario y correo y validez de contraseña.
6. Sistema crea usuario temporal y envia correo electrónico de validación notificando a la persona.
7. Persona valida usuario. Sistema lleva a página de inicio de seción.}
8. Fin CU.

**CAMINOS ALTERNATIVOS:**

3.**\<En lugar de\>** Persona elige "O unirse con Facebook/Google".\
&nbsp;&nbsp;&nbsp;&nbsp;3.a Fin CU. Iniciar CU-00x.\
*¿Lo ponemos acá o hacemos un CU explusivo para los logueos por otro medios?*\
   *Cualquiera sea el caso, si ya se ha logueado anteriormente con otro medio, debería saltar al iniciar sesión*\
5.**\<Posterior\>** Usuario o correo ya han sido utilizados o la contraseña es insegura.\
&nbsp;&nbsp;&nbsp;&nbsp;5.a Notifica a la persona. Vuelve al paso 2.\
6.**\<Previo\>** Persona sale del sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;6.a Fin CU.\
7.**\<En lugar de\>** Persona no valida usuario en x días.\
&nbsp;&nbsp;&nbsp;&nbsp;7.a Sistema elimina usuario temporal. Fin CU.
    
**POSTCONDICIONES (de sistema):**

**Éxito:** Se registra usuario.

**Éxito alternativo:** Se registra usuario enlazado a cuenta de Facebook/etc.

**Fracaso:** No se crea usuario y/o usuario temporal es eliminado.
