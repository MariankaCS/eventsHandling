using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Student
    {
        private string name;
        private List<int> marks = new List<int>();
        
        //public List<int> Marks {get; set;}
        public delegate void MyDel(int m);

        public event MyDel MarkChange;

        public void AddMark(int mark)
        {
            marks.Add(mark);

            if (MarkChange != null)
            {
                MarkChange(mark);
            }
        }
    }
}
