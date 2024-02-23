La capa de mapeo tiene la responsabilidad exclusiva de facilitar la conversión
entre las estructuras de datos específicas de la DAL y los tipos de datos
nativos de C#. Su función principal es realizar el mapeado de datos, permitiendo
una comunicación efectiva entre la capa de acceso a datos (DAL) y las capas
superiores del sistema. Esta capa se encarga de convertir la información entre
las representaciones de datos utilizadas por la DAL y las estructuras de datos
de C#, asegurando así una transición fluida entre ambas sin agregar
responsabilidades adicionales. Al mantener un enfoque claro en el mapeo de
datos, esta capa sigue los principios SOLID, evitando la sobrecarga de
responsabilidades y contribuyendo a la claridad y mantenibilidad del sistema de
persistencia mixto (SQL y XML).