﻿using ABS;

using ASL;

using BEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class ClienteBLL : IABMC<Cliente>
    {
        ClienteASL clienteASL = new ClienteASL();

        public bool Modificar(Cliente objeto)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Cliente objeto)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(Cliente objeto)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Consultar()
        {
            return clienteASL.Consultar();
        }
    }
}
