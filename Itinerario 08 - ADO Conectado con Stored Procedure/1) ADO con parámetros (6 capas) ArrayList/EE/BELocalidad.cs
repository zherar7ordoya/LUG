﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
