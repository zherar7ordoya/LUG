namespace LUG.BE
{
    public class BECliente
    {
        public long Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long DNI { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return $"{Apellido} - {Nombre} - {DNI}";
        }
    }
}
