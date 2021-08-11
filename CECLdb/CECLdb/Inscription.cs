using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Inscription
    {
        private string area;
        public int idArea;
        private string course;
        private int idCourse;
        private string person;
        private int idPerson;
        private string startDate;
        private string endDate;
        private int approved;

        public int IDarea { get => idArea; set => idArea = value; }
        public string Area { get => area; set => area = value; }
        public int IDcurso { get => idCourse; set => idCourse = value; }
        public string Curso { get => course; set => course = value; }
        public int IDpersona { get => idPerson; set => idPerson = value; }
        public string Nombre { get => person; set => person = value; }
        public string FechaInicio { get => startDate; set => startDate = value; }
        public string FechaFin { get => endDate; set => endDate = value; }
        public int Aprobado { get => approved; set => approved = value; }
    }
}
