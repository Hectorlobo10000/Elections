using System.Collections.Generic;
using Dapper;
using Elections.Server.Library.Model;

namespace Elections.Server.Library.Repository
{
    public class DataBase : Database<DataBase>
    {
        public Table<Student> Students { get; set; }
        public Table<Grade>  Grades { get; set; }
        public Table<Section> Sections { get; set; }
        public Table<Sex> Sexes { get; set; }
        //public Table<BallotPaper>  Candidates { get; set; }

        public IEnumerable<Student> AllStudents;
        public IEnumerable<Grade> AllGrades;
        public IEnumerable<Section> AllSections;
        public IEnumerable<Sex> AllSexes;

    }
}