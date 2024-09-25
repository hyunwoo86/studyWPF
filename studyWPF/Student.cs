using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Student
    {
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string BirthDay { get; set; } = "";
        public string School { get; set; } = "";

        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Birthday: {BirthDay}, School: {School}";
        }

        public static List<Student> Students = new List<Student>()
        {
            new  Student{Name ="1", Gender="남", BirthDay="a", School="A"},
            new  Student{Name ="2", Gender="남", BirthDay="b", School="B"},
            new  Student{Name ="3", Gender="여", BirthDay="c", School="C"},
            new  Student{Name ="4", Gender="남", BirthDay="d", School="D"},
            new  Student{Name ="5", Gender="남", BirthDay="e", School="E"},
            new  Student{Name ="6", Gender="여", BirthDay="f", School="F"},
        };
    }
}
