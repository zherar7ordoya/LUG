La capa de acceso a datos (DAL) tiene como responsabilidad principal gestionar
la ubicación y persistencia de los datos, determinando "dónde" se almacenan los
datos del sistema. Esto implica proporcionar mecanismos para interactuar con el
repositorio de datos correspondiente, ya sea un servidor SQL o archivos XML. La
DAL recibe la información estructurada desde la capa mapeadora y utiliza esta
información para realizar las operaciones de almacenamiento y recuperación en el
repositorio de datos específico, manteniendo así la separación de preocupaciones
en cuanto a la persistencia.