namespace Elections.Server.Library.Model
{
    public class Student
    {
        public int Index { get; set; }
        public int Number { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public bool Vote { get; set; }
        public int IdSex { get; set; }
        public int IdGrade { get; set; }
        public int IdSection { get; set; }
         
    }
}