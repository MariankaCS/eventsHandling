using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{

    public class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            Student s1 = new Student();
            s1.MarkChange += (m) => p1.OnMarkChange(m);
            s1.AddMark(10);
            s1.AddMark(12);
            s1.AddMark(11);
            s1.AddMark(9);
            Console.ReadLine();
           
        }
    }

}
