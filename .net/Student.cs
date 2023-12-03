using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOfAbstration
{
    public class Student
    {
        public string Name{ get; set; }
        public int Age { get; set; }
        public string GetStudentDetail(){
            return $"Student nme : ${Name} and age : {Age}";
        }
    }
}