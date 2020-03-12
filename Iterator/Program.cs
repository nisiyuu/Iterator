using System;

namespace C_
{
    class Program
    {
            public static void Main(string[] args){
                Teacher you = new MyTeacher();
                you.createStudentList();
                you.callStudents();
            }
    }
}
