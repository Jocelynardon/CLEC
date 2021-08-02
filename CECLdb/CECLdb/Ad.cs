using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Ad
    {
        private int idAd;
        private string area;
        private string course;
        private string date;
        private string description;

        public int IDaviso { get => idAd; set => idAd = value; }
        public string Area { get => area; set => area = value; }
        public string Curso { get => course; set => course = value; }
        public string Fecha { get => date; set => date = value; }
        public string Descripcion { get => description; set => description = value; }
    }
}
