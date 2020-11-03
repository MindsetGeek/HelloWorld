using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HelloWorld.Student;
using HelloWorld.Teacher;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            YYYY.Profile prof = new YYYY.Profile();
            prof.NameShow();

            Teacher.Profile teacgerprof = new Teacher.Profile();
            teacgerprof.NameShow();

            Console.ReadLine();
        }
    }
}
