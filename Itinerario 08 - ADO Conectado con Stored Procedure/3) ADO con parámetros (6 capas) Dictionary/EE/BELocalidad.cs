namespace BE
{
    public  class BELocalidad:Entidad
    {
        
            public string Descripcion { get; set; }
       

            public override string ToString()
            {
	            return Id + " " + Descripcion;
            }
    }
}
