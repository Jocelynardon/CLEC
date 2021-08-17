using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Ad
    {
        private int idAd;
        private string area;
        public int idArea;
        private string course;
        private int idCourse;
        private DateTime date;
        private string description;

        public int IDaviso { get => idAd; set => idAd = value; }
        public int IDarea { get => idArea; set => idArea = value; }
        public string Area { get => area; set => area = value; }
        public string Curso { get => course; set => course = value; }
        public int IDcurso { get => idCourse; set => idCourse = value; }
        public DateTime Fecha { get => date; set => date = value; }
        public string Descripcion { get => description; set => description = value; }
    }
}
