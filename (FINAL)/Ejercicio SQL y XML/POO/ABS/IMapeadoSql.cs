using System.Collections.Generic;


namespace ABS
{
    // ¿Era necesaria esta interfaz? Yo creo que sí ya que la implementa cada
    // mapeador de cada entidad.
    public interface IMapeadoSql<T> where T : IEntidad
    {
        /// <summary>
        /// Convierte un DataTable en una lista de objetos T.
        /// </summary>
        /// <param name="stored">
        /// TRUE si la consulta es un procedimiento almacenado.
        /// FALSE si la consulta es un comando de texto.
        /// </param>
        /// <param name="consulta">
        /// Nombre del procedimiento almacenado o comando de texto.
        /// </param>
        /// <returns></returns>
        List<T> MapearDesdeSql(bool stored, string consulta);


        /// <summary>
        /// Convierte un objeto T en un comando SQL.
        /// </summary>
        /// <param name="stored">
        /// TRUE si la consulta es un procedimiento almacenado.
        /// FALSE si la consulta es un comando de texto.
        /// </param>
        /// <param name="consulta">
        /// Nombre del procedimiento almacenado o comando de texto.
        /// </param>
        /// <param name="objeto">
        /// El objeto T a mapear.
        /// </param>
        /// <returns></returns>
        bool MapearHaciaSql(bool stored, string consulta, T objeto);
    }
}
