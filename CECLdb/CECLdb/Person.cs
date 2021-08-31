using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Person
    {
        private int idPerson;
        private int telephone;
        private string name;
        private string email;
        private string lastname;
        private string area;
        private string course;

        public int ID { get => idPerson; set => idPerson = value; }
        public string Nombre { get => name; set => name = value; }
        public string Apellido { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public int Teléfono { get => telephone; set => telephone = value; }
        public string Área { get => area; set => area = value; }
        public string Curso { get => course; set => course = value; }
    }
}
