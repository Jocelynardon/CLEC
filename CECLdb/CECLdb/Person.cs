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
        private string codePerson;

        public int IdPerson { get => idPerson; set => idPerson = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string CodePerson { get => codePerson; set => codePerson = value; }

    }
}
