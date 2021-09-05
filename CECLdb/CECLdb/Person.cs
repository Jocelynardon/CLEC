using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class Person
    {
        private int idPerson;
        private string telephone;
        private string name;
        private string email;
        private string lastname;

        public int ID { get => idPerson; set => idPerson = value; }
        public string Nombre { get => name; set => name = value; }
        public string Apellido { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Teléfono { get => telephone; set => telephone = value; }

    }
}
