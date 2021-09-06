using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class People
    {
        private int idPerson;
        private string telephone;
        private string name;
        private string email;
        private string lastname;
        private string area;
        private string course;
        private string code;
        private string startDate;
        private string endDate;
        private string approved;
        private string description;
        private string dateAd;

        public int ID { get => idPerson; set => idPerson = value; }
        public string Nombre { get => name; set => name = value; }
        public string Apellido { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Teléfono { get => telephone; set => telephone = value; }
        public string Área { get => area; set => area = value; }
        public string Curso { get => course; set => course = value; }
        public string Código { get => code; set => code = value; }
        public string FechaInicio { get => startDate; set => startDate = value; }
        public string FechaFin { get => endDate; set => endDate = value; }
        public string Aprobado { get => approved; set => approved = value; }
        public string Descripción { get => description; set => description = value; }
        public string FechaAviso { get => dateAd; set => dateAd = value; }
    }
}
