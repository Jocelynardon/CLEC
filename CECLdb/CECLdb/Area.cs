﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Area
    {
        private int idArea;
        private int convocatoria;
        private int año;
        private string nombre;
        public int IDarea { get => idArea; set => idArea = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }
        public int Convocatoria { get => convocatoria; set => convocatoria = value; }
    }
}
