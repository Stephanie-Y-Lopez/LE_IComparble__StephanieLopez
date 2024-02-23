using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble__StephanieLopez
{
    class Student_SortGenedgrade : IComparer<Student>
    {
        public enum SortingOrder { Ascending, Descending};
        public SortingOrder Sorting;

        public Student_SortGenedgrade()
        {
            Sorting = SortingOrder.Ascending;
        }

        public Student_SortGenedgrade(SortingOrder sorting)
        {
            Sorting = sorting;
        }

        public int Compare(Student x, Student y)
        {
            if(Sorting == SortingOrder.Ascending)
            {
                return x.GenEdGrade.CompareTo(y.GenEdGrade) * -1;
            }
            else
            {
                return x.GenEdGrade.CompareTo(y.GenEdGrade);
            }
        }
    }
}
