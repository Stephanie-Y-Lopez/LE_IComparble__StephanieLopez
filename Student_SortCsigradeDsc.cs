using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble__StephanieLopez
{
    class Student_SortCsigradeDsc : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            //if (x.CSIGrade < y.CSIGrade) return 1;
            //else if (x.CSIGrade > y.CSIGrade) return -1;
            //else return 0;

            return x.CSIGrade.CompareTo(y.CSIGrade);
        }
    }
}
