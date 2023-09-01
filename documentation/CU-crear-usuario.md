**Código y Nombre del CASO  DE  USO:** CU-001 - Creación de usuario

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Persona crea su usuario en la plataforma con el cual ya podrá navegar, donar y crear campañas (básicas).

**ACTORES** 

**Primario:** Persona

**Iniciador:** Persona

**Otros:** <vacío>

**PRECONDICIONES (de negocio):** --

**PRECONDICIONES (de sistema):** --

**DISPARADOR:** Persona decide crear usuario en la plataforma.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Persona entra a la plataforma y elige la opción "Unirse a Give".
2. Sistema muestra formulario de creación de usuario:
   - Usuario.
   - Contraseña.
   - Correo.
   - Nombre. (OPCIONAL)
   - Apellido. (OPCIONAL)
   - Dni. (OPCIONAL)
3. Usuario completa información y apreta "Crear usuario".
4. Sistema valida inexistencia de usuario y correo y validez de contraseña.
5. Sistema crea usuario temporal y envia correo electrónico de validación notificando a la persona.
6. Persona valida usuario. Sistema lleva a página de inicio de seción.}
7. Fin CU.

**CAMINOS ALTERNATIVOS:**
3. <En lugar de> Persona elige "O unirse con Facebook/Google".
    3.a Fin CU. Iniciar CU-00x. **¿Lo ponemos acá o hacemos un CU explusivo para los logueos por otro medios?**
    **Cualquiera sea el caso, si ya se ha logueado anteriormente con otro medio, debería saltar al iniciar sesión**
4. <Posterior> Usuario o correo ya han sido utilizados o la contraseña es insegura.
    4.a Notifica a la persona. Vuelve al paso 2.
5. <Previo> Persona sale del sistema.
    5.Fin CU.
6. <En lugar de> Persona no valida usuario en x días.
    6.a Sistema elimina usuario temporal. Fin CU.
    
**POSTCONDICIONES (de sistema):**

**Éxito:** Se registra usuario.

**Éxito alternativo:** Se registra usuario enlazado a cuenta de Facebook/etc.

**Fracaso:** No se crea usuario y/o usuario temporal es eliminado.
