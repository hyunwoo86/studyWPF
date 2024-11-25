using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyWPF
{
    class Student
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Birthday { get; set; } = "";
        public string Schol { get; set; } = "";

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Birthday: {Birthday}, School: {Schol}";
        }

        public static List<Student> Students = new List<Student>()
        {
            new Student { Name="김성현", Gender="남", Birthday="19800201", Schol="서울대"},
            new Student { Name="나민정", Gender="남", Birthday="19879028", Schol="고려대"},
            new Student { Name="정민지", Gender="여", Birthday="19769283", Schol="연세대"},
            new Student { Name="김둘리", Gender="남", Birthday="11119838", Schol="전남대"},
            new Student { Name= "김수", Gender="여", Birthday="11119838", Schol="충남대"},
        };
    }
}
