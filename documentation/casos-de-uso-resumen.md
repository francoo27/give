## Usuario
- **Creación**
    - Mediante aplicación
    - Ingreso de usuario via red social (google, apple, facebook, etc)
- **Recupero de contraseña**
- **Banear usuario**
    - Luego de identificar múltiples infracciones leves o actos delictivos _banear_ la cuenta.
- **Ver perfil**
    - Edición de Datos personales básicos
        -Restringir edición de datos importantes para la validación de identidad del usuario
    - Usuario ve historial de campañas a las que aportó, pudiendo ver las campañas actuales y suscripciones activas.
        - Estadísticas de donaciones?
    - Descarga de toda información referida a él (Auditoría)
    - Pedido de eliminar usuario y que repercuta en el sistema (Ej, en una campaña deja de aparecer su nombre)

- **Onboarding usarios**
    - Seleccion entre persona fisica y juridica
    - Dependiendo de la seleccion se mostraran diferentes fromularios con la informacion necesaria en cada caso
        - Registro express (puede presentar toda la documentacion desp)
Denunciar una persona fisica/juridica

## Campañas solicitante (Usuarios):
- **Crear campaña**
    -  Si no esta validado se llama a CU Validación identidad. (No necesariamente impedimos que siga con la creación de la campaña). Usuario crea campaña única o continua (creador de contenido) describiendo la campaña, dependiendo el caso puede cargar comprobantes. Llama a CU validación campaña a priori.
    - Aca definimos que tipo de campaña se va a hacer  por ej si es a un monto que si o si es necesario llegar a un cierto monto o es abierta, montos, tiempos 
- **Editar proyecto**
    - se puede contemplar la presentacion de documentacion extra, avance de proyecto, evidencias, etc	
    - _milestones_
    - ejecución inmediata
    - _crowdfunding_
- **Moderar proyectos**
    - Bloqueo manual de parte del usuario
    - Bloqueo por parte de un administrador por sospecha de fraude
    - Pausar proyecto
        - Puede dejarla en _hold_ por algún motivo de la organización (debe ser temporal)
    - Cerrar campaña
        - Usuario solicitante marca campaña como finalizada.
    - Pedir documentación
    - Carga comprobantes de fin de campaña
        - Usuario carga comprobantes de que el proyecto se ha realizado. Llama a CU validar a posteriori.
    - Moderar donaciones
        - retener donación[^1]
        - Devolución de dinero a persona particular[^2]
        - Puede llegar a solicitar devolución de dinero a los que aportaron
    - Moderar denuncias
        - desestimar
        - banear
        - denuncia legal[^3]
    - Validar campaña a _priori_
        - Se valida que los comprobantes son verdaderos
        - Autorización / verificación de campaña
    - Transferencia de dinero al finalizar la campaña[^4]

## Campañas donante (Usuarios):
- Buscar campañas
    - Usuario busca campañas o creadores filtrando, pudiendo entrar a dicha campaña.
    - Donar
        - Usuario dona monto. Si se quiere donar mucho dinero o reitera su donación varias veces se solicita que valide la identidad.
    - Valorar campaña o solicitante
        - Usuario puede dar crítica a la campaña o al solicitante según su experiencia. (**Restricción:** haber participado en el proyecto)
        - Comentar un proyecto
    - Reportar fraude
        - Usuario reporta que la campaña es fraudulenta (No que no se logre cumplir, si no que es falsa)
        - **Fraude financiero:** Implica actividades engañosas relacionadas con las finanzas, como estafas de inversión, manipulación de cuentas, emisión de cheques sin fondos, entre otros.
        - Datos erróneos de la campaña, los que generan la campaña presentan papeles falsos de informes financieros o requerimientos
        - **Fraude de identidad:** Se refiere a robar la identidad de otra persona para obtener beneficios financieros, como abrir cuentas bancarias falsas, solicitar tarjetas de crédito a nombre de otra persona o realizar transacciones fraudulentas.
            - suplantan la identidad de una persona creando una campaña a su nombre
        - **Fraude en línea:** Incluye estafas en línea, phishing y suplantación de identidad en internet. Puede implicar engañar a las personas para que divulguen información personal o financiera.   
        - **Fraude de tarjetas de crédito/débito:** Incluye el uso no autorizado de tarjetas de crédito o débito para realizar compras o transacciones financieras fraudulentas.
            - Denunciar que utilizaron tarjetas de una persona para donar sin su consentimiento a una campaña / suscripción
        - **Fraude hipotecario:** Se relaciona con la obtención de préstamos hipotecarios mediante la presentación de información financiera falsa o engañosa.
            - crean campañas para comprar un inmueble que tiene papel falsificado
        - **Fraude de bienes raíces:** Implica engaños en la compra, venta o alquiler de propiedades, como falsificación de documentos, declaraciones falsas sobre el estado de la propiedad, etc. 
            - crean campañas para comprar un inmueble que tiene papel falsificado
        - **Fraude de productos/servicios:** Implica la venta de productos o servicios falsificados o fraudulentos, como medicamentos falsos, productos milagrosos o servicios inexistentes 
            - crean campañas de eventos, organizaciones, concursos o cualquier otro tipo de entidad que no exista realmente

## Campañas (Sistema):
- Validar campaña a posteriori
    - Se valida que los comprobantes son verdaderos.
- Ponderar donantes
    - El sistema de puntaje a los usuarios según el cumplimiento de sus campañas y las condiciones de estas
- Elegir campaña por tema
    - El Sistema elige a fin de mes, campaña para cada tema (ecología, comedor, etc) según ponderación del donante y recurrencia en esta opción de financiamiento.

## Suscripción
- Alta de suscripción
    - Asociar temática (categoría, tags, etc.. identificadores)[^5]
- Descripción de la persona dentro de la suscripción
- _Tiers_ de suscripción
    - Recompensas por _tiers_
- Dar de baja suscripción
    - Usuario cancela suscripción activa.
- Suscribir a una persona (**Restricción:** cuenta verificada)
	a. específico
	b. general (categoría)

## Reportar error
- Usuario notifica error en la aplicación (mesa de ayuda).

## Monitoreo tiempo real
- Donaciones
    - Que se done un alto monto[^6]
    - Que se done con una frecuencia alta[^7]
    - Que un usuario reciba dinero de un usuario al el que el donar
- Denuncias
    - muchas denuncias a una cuenta en particular (_review bomb_)

## Auditoría
- Aca basicamente cualquier persona podria hacer una query que contenga toda la     informacion dels sitema obviando los datos sensibles
    - Por ejemplo: se podria traquear el avance de una campaña en el tiempo
        - generar estadísticas
    - Otro ejemplo: si se denuncia una campaña, poder ver quien denuncio que moderador atendio las denuncias y como lo resolvio , hace cuanto se crearon la cuenta los que denuncian, comentarios de la denuncia, _review_ etc etc

## Notas

[^1]: Hay que analizar si hacemos de intermediario entre las donaciones, tiene el punto negativo de duplicar comisiones que le cobramos al usuario final. Punto positivo, tenemos poder de intervenir en la donaciones que tegan algun problema (evitar lavado de dinero)

[^2]: _idem_ punto 1

[^3]: falta analizar

[^4]: _idem_ punto 1

[^5]: ¿Hace falta que una vez autenticado el usuario ponga algo para el alta? o ya por existir una persona puede recibir plata de suscripción

[^6] ¿Que es un monto alto?

[^7] ¿Qué es una frecuencia alta?