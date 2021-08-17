using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Register
    {
        private string area;
        public int idArea;
        private string course;
        private int idCourse;
        private string person;
        private int idPerson;
        private DateTime consultationDate;

        public int IDarea { get => idArea; set => idArea = value; }
        public string Area { get => area; set => area = value; }
        public int IDcurso { get => idCourse; set => idCourse = value; }
        public string Curso { get => course; set => course = value; }
        public int IDpersona { get => idPerson; set => idPerson = value; }
        public string Nombre { get => person; set => person = value; }
        public DateTime FechaConsulta { get => consultationDate; set => consultationDate = value; }
    }
}
