**CASO DE USO: CU-003 - Informar avance de Campaña**

**Meta del CASO DE USO:** Permitir a los usuarios que puedan presentar documentación o informar acerca de acontecimientos sobre la campaña para transmitir transparencia sobre el proceso y generar confianza en los donadores.

**ACTORES**

**Primario:** Usuario registrado

**Iniciador:** Usuario registrado

**PRECONDICIONES (de negocio):**
- El usuario debe estar registrado en la plataforma.
- El usuario debe tener una campaña ya creada.
- La campaña debe pertenecer al usuario que quiere editar la misma. ([ACL](https://es.wikipedia.org/wiki/Lista_de_control_de_acceso))

**DISPARADOR:** El usuario decide presentar un informe sobre el avance de la campaña.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. El usuario accede a la lista de campañas en la plataforma.
2. Selecciona una campaña con estado distinto de final ([RN-003](./reglas-de-negocio.md/#3)).
3. El usuairio puede presentar un avance del proyecto completando un formulario que generara un _post_ donde puede incluir texto, imagenes, documentos, etc ([RN-006](./reglas-de-negocio.md/#6))
4. El usuario envía el formulario del avance de la campaña.
5. El sistema valida los campos del formulario.