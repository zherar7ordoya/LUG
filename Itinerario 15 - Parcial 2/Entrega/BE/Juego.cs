﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Juego : Entidad
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}
