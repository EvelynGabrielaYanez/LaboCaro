﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoEncontradoExcepcion : Exception
    {
        public NoEncontradoExcepcion(string mensaje) : base(mensaje)
        {

        }
    }
}
