using LUG.Parametros;

namespace LUG.BE
{
    public abstract class BEStreaming
    {
        public long Codigo { get; set; }
        public string Nombre { get; set; }
        public double Duracion { get; set; }
        public ECategoria Categoria { get; set; }
        public override string ToString()
        {
            return $"{Nombre} - {Categoria.ToString()} - {Duracion} - {Codigo.ToString()}";
        }
    }
}
