namespace ABS
{
    // Tener tanto interfaces como enumeradores en la capa de abstracción es
    // considerado una buena práctica de diseño en arquitecturas de software por
    // coherencia: al tenerlos centralizados, se asegura que todas las capas y
    // módulos del sistema utilicen las mismas definiciones. Esto promueve la
    // consistencia a lo largo de todo el sistema y facilita la comprensión
    // global del código. 
    public enum EstadoFormulario
    {
        Normal,
        Alta,
        Modificacion
    }
}
