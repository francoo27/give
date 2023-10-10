# R11 - Demanda de usuarios alta

 Posible Resultado | Síntoma | Probabilidad | Impacto | Prioridad |  Responsable |
|-------------------|---------|--------------|---------|-----------|-----------|
Imposibilidad de respuestas por parte del servidor  | Errores 429 en los _logs_ del servidor | Medio 🟡 | Muy alto 🔴 | 15 | Asignar más recursos al servidor/Levantar mas instancias para satisfacer la demanda | Área de Tecnología |

## Problematica

El servidor recibe demasiadas peticiones por lo que no puede dar respuesta a todas estas.

## Medidas de prevención

1. Llevar métricas de consumo del servidor, y hacer análisis de manera frecuente para prever la necesidad de aumentar la potencia del servidor u otra alternativa.
2. Limitar cantidad de pedidos por usuario.
3. Contratar un servidor escalable de manera sencilla.
4. Contratar servidor de caché, para atender solicitudes repetidas.
5. Periodicamente simular exceso de solicicitudes para probar la respuesta a este riesgo.

## Medidas de mitigación

1. Limitar velocidad de solicitudes
