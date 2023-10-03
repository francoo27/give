# R1 - Fallo de seguridad de datos

 Posible Resultado | Síntoma | Probabilidad | Impacto | Prioridad |  Responsable |
|-------------------|---------|--------------|---------|-----------|-----------|
| Compromiso de datos de usuarios y pérdida de confianza | Aumento de quejas de usuarios sobre accesos no autorizados | Alto 🟠| Muy alto 🔴| 20 | Área de Seguridad

## Problematica

Segun la [Ley 25.326](http://servicios.infoleg.gob.ar/infolegInternet/anexos/60000-64999/64790/norma.htm) articulo 9 establece que _"que **el responsable del archivo de datos** debe tomar las medidas técnicas y organizativas necesarias para **garantizar la seguridad y confidencialidad de los datos personales, y evitar su alteración, pérdida, acceso no autorizado o tratamiento indebido**. Prohíbe registrar datos personales en archivos que no cumplan con las condiciones técnicas de integridad y seguridad."_, lo que implica que debemos tomar las medidas de prevecion necesarias para evitar que los datos de los usuarios pueda ser filtrados.

## Medidas de prevención

1. Encriptación de datos
2. Prevención de acceso a información ajena mediante [ACL](https://es.wikipedia.org/wiki/Lista_de_control_de_acceso)
3. Configuración de un _firewall_
4. Implementa herramientas de monitoreo de seguridad para rastrear el tráfico y el comportamiento del servidor en busca de anomalías y actividades sospechosas.
5. Registros de seguridad detallados (trazabilidad de los movimientos).

## Medidas de mitigación

Para evitar que se siga filtrando información sensible se prodecera con el siguiente plan de contigencia

1. Se suspendera el servicio del servidor (Mondo mantenimiento), para evitar que se siga filtrando información
2. Bloquear la ip del usuario que esta accediendo a información confidencial
3. Monitorear _logs_/registros para poder encontrar la vulnerabilidad
4. hacer un _hot fix_ para solucionar el _issue_
5. Restablecer servicio de servidor
6. Informar situación