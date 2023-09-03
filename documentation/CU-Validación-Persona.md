**Código y Nombre del CASO  DE  USO:** CU-004 - Validación de identidad

| Nivel  | Estructura | Alcance|Caja|Instanciacion| Interaccion|
|:------- |:-------|:-----|:-----|:-----|:-----|
| Resumen    | Estructurado | Sistema |Negra |Real |Semantico|

**Meta del CASO  DE  USO:** Validar identidad de persona física o jurídica de usuario.

**ACTORES** 

**Primario:** Usuario

**Iniciador:** Usuario

**Otros:** SID Renaper, respondable de validación.


**PRECONDICIONES (de negocio):** --

**PRECONDICIONES (de sistema):** Existe usuario.

**DISPARADOR:** Usuario decide validar su identidad para poder hacer uso de más funciones de Give.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. Usuario desde su perfil va a opción "Validar identidad".
2. Sistema muestra formulario de validación de persona física:
      - Nombre.
      - Apellido.
      - DNI
      - Foto frontal y de dorso de DNI.
      - 2 fotos de cara.
3. Usuario completa formualario.
4. Sistema envia datos a SID RENAPER.
5. SID RENAPER confirma identidad.
6. Sistema confirma validación e informa al usuario.
7. Fin CU.

**CAMINOS ALTERNATIVOS:**

1.**\<Previo\>** Usuario intenta crear una campaña o hacer una donación que necesita validar identidad.\
&nbsp;&nbsp;&nbsp;&nbsp;1.a.1 Sistema informa al usuario.\
&nbsp;&nbsp;&nbsp;&nbsp;1.a.2 Usuario se dirige a "Validar identidad".\
2.**\<En lugar de\>** Usuario es creado como persona jurídica.\
&nbsp;&nbsp;&nbsp;&nbsp;2.a.1 Sistema muestra formulario de validación de persona jurídica.
   - Razón Social
   - Dirección.
   - Documento firmado por representante legal de la organización.

4.**\<En lugar de\>** Usuario es creado como persona jurídica.\
&nbsp;&nbsp;&nbsp;&nbsp;4.a.1 Sistema envia datos a responsable de validación.\
&nbsp;&nbsp;&nbsp;&nbsp;4.a.2 Responsable de validación valida identidad jurídica. Continua paso 7\
4.**\<En lugar de 4.a.2\>** Responsable de validación rechaza identidad jurídica. \
&nbsp;&nbsp;&nbsp;&nbsp;4.b.2 Notifica al usuario. Vuelve al paso 2.\
5.**\<En lugar de\>** SID RENAPER rechaza identidad.\
&nbsp;&nbsp;&nbsp;&nbsp;5.a.1 Notifica al usuario. Vuelve al paso 2.\
6.**\<Previo\>** Persona sale del sistema.\
&nbsp;&nbsp;&nbsp;&nbsp;6.a.1 Fin CU.
    
**POSTCONDICIONES (de sistema):**

**Éxito:** Usuario de persona fisica validado.

**Éxito alternativo:** Usuario de persona jurídica validado.

**Fracaso:** Usuario sin validar.
