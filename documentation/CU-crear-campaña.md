**CASO DE USO: CU-002 - Creación de Campaña**

**Meta del CASO DE USO:** Permitir a los usuarios crear una nueva campaña de crowdfunding en la plataforma.

**ACTORES**

**Primario:** Usuario registrado

**Iniciador:** Usuario registrado

**Otros:** Moderador (para casos especiales de ejecución inmediata)

**PRECONDICIONES (de negocio):**
- El usuario debe estar registrado en la plataforma.
- El usuario debe tener los permisos necesarios para crear una campaña.

**DISPARADOR:** El usuario decide crear una nueva campaña de crowdfunding.

**FLUJO DE SUCESOS**

**CAMINO BÁSICO:**

1. El usuario accede a la opción de crear una nueva campaña en la plataforma.
2. El sistema muestra un formulario de creación de campaña con los siguientes pasos:
   - Paso 1: Descripción del Proyecto
   - Paso 2: Fondos Necesarios
   - Paso 3: Recompensas
   - Paso 4: Plan de Progreso
3. En el **Paso 1: Descripción del Proyecto**, el usuario completa la siguiente información:
   - Título de la campaña: [campo de texto]
   - Descripción de la campaña: [campo de texto largo]
   - Fecha de inicio y finalización: [campo de selección de fechas]
   - Personas involucradas: [campo de texto]
   - Categoría principal: [campo de selección]
   - Subcategorías: [campo de selección múltiple]
   - Tipo de Crowdfunding: [Por Tiempo, Por Monto, Ejecución Inmediata]
4. El usuario pasa al **Paso 2: Fondos Necesarios**, donde debe desglosar en una tabla los fondos necesarios por ítem, incluyendo materiales, objetos, productos, horas hombre y precio de hora hombre.
5. Luego, en el **Paso 3: Recompensas**, el usuario describe las recompensas que ofrecerá a los donantes por donar ciertos montos.
6. Finalmente, en el **Paso 4: Plan de Progreso** (Opcional), el usuario establece checkpoints dentro del rango de fechas de la campaña para mostrar el progreso de la misma.
7. El usuario envía el formulario de creación de campaña.
8. El sistema valida los campos del formulario.
9. Si el usuario está validado:
   - La campaña queda en estado PAUSADA, esperando su validación.
10. Si el usuario no está validado:
    - La campaña queda en estado ACTIVA.

**CAMINOS ALTERNATIVOS:**

**Para el crowdfunding "Por Tiempo" y "Por Monto":**

5a. El usuario no completa algún campo obligatorio en cualquiera de los pasos:
   - El sistema muestra un mensaje de error al usuario indicando que se deben completar todos los campos obligatorios.
   - El usuario vuelve al paso correspondiente para completar los campos faltantes.

5b. El usuario no puede crear la campaña de manera satisfactoria:
   - El sistema muestra un mensaje de error al usuario indicando que ha ocurrido un problema y no se puede crear la campaña en este momento.
   - El sistema proporciona un enlace o formulario de contacto para que el usuario pueda contactar al soporte y reportar el problema.
   - El usuario puede hacer clic en el enlace o completar el formulario para contactar al soporte.

**Para el crowdfunding "Por Monto" (Caso 1 - No llega a la meta):**

5c. La campaña no alcanza la meta de recaudación especificada dentro del tiempo especificado:
   - El sistema muestra un mensaje informativo al usuario indicando que la campaña no ha alcanzado la meta de recaudación.
   - La campaña se marca como "No exitosa" en la plataforma.

**Para el crowdfunding "Por Monto" (Caso 2 - Supera la meta):**

5d. La campaña supera la meta de recaudación especificada dentro del tiempo especificado:
   - El sistema muestra un mensaje de éxito al usuario indicando que la campaña ha alcanzado o superado la meta de recaudación.
   - La campaña se marca como "Exitosa" en la plataforma.
