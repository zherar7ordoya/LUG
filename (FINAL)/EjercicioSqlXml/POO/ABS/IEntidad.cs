namespace ABS
{
    // ...y éste el motivo por el cual en la base de datos uso "Codigo" como
    // nombre de campo para la clave primaria (y no "Id").
    public interface IEntidad
    {
        int Codigo { get; set; }
    }
}
