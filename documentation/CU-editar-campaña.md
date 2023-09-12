**CASO DE USO: CU-003 - Edición de Campaña**

**Meta del CASO DE USO:** Permitir a los usuarios editar una campaña de crowdfunding en la plataforma.

**ACTORES**

**Primario:** Usuario registrado

**Iniciador:** Usuario registrado

**PRECONDICIONES (de negocio):**
- El usuario debe estar registrado en la plataforma.
- El usuario debe tener los permisos necesarios para editar una campaña.
- El usuario debe tener una campaña ya creada.
- La campaña debe pertenecer al usuario que quiere editar la misma. ([ACL](https://es.wikipedia.org/wiki/Lista_de_control_de_acceso))

**DISPARADOR:** El usuario decide editar una campaña.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. El usuario accede a la lista de campañas en la plataforma.
2. Selecciona una campaña con estado distinto de final ([RN-003](./reglas-de-negocio.md/#3)).
3. En el **Paso 1: Descripción del Proyecto**, el usuario podra editar la siguiente información:
   - Título de la campaña: [campo de texto]
   - Descripción de la campaña: [campo de texto largo]
   - ~~Fecha de inicio y finalización~~ ([RN-004](./reglas-de-negocio.md/#4))
   - Personas involucradas: [campo de texto]
   - Categoría principal: [campo de selección]
   - Subcategorías: [campo de selección múltiple]
   - ~~Tipo de Crowdfunding~~ ([RN-005](./reglas-de-negocio.md/#5))
4. El usuario pasa al **Paso 2: Fondos Necesarios**, donde debe desglosar en una tabla los fondos necesarios por ítem, incluyendo materiales, objetos, productos, horas hombre y precio de hora hombre.
5. Luego, en el **Paso 3: Recompensas** (Opcional), el usuario puede editar las recompensas que ofrecerá a los donantes por donar ciertos montos (_tiers_).
6. Finalmente, en el **Paso 4: Plan de Progreso** (Opcional), el usuario puede editar checkpoints dentro del rango de fechas de la campaña para mostrar el progreso de la misma.
7. El usuario envía el formulario de edición de campaña.
8. El sistema valida los campos del formulario.