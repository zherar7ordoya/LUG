﻿using System.Collections.Generic;

namespace BLL
{
    public class DescuentoCalculado : ABS.IGestor<BEL.DescuentoCalculado>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.DescuentoCalculado descuento;
        public DescuentoCalculado()
        {
            this.descuento = new DML.DescuentoCalculado();
        }

        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.DescuentoCalculado Detallar(BEL.DescuentoCalculado descuento)
        {
            return this.descuento.Detallar(descuento);
        }

        public bool Eliminar(BEL.DescuentoCalculado descuento)
        {
            return this.descuento.Eliminar(descuento);
        }

        public bool Guardar(BEL.DescuentoCalculado descuento)
        {
            return this.descuento.Guardar(descuento);
        }

        public List<BEL.DescuentoCalculado> Listar()
        {
            return this.descuento.Listar();
        }
    }
}
