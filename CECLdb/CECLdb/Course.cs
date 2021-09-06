namespace CLEC
{
    class Course
    {
        private int idArea;
        private int idCourse;
        private string nombre;
        private string area;
        public int IDarea { get => idArea; set => idArea = value; }
        public int IDcurso { get => idCourse; set => idCourse = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Area { get => area; set => area = value; }
    }
}
