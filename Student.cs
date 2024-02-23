using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_IComparble__StephanieLopez
{
    internal class Student
    {
        //Fields
        public string _Firstname;
        public string _Lastname;
        public double _Csigrade;
        public double _Genedgrade;

        //Constructor
        public Student(string Firstname, string Lastname)
        {
            _Firstname = Firstname;
            _Lastname = Lastname;
            Random Rand = new Random();
            _Csigrade = Rand.Next(30, 102); //Generates Grade within that number range
            _Genedgrade = Rand.Next(10, 101); //Generates Grade within that number range
        }

        //Properties
        public string FirstName { get => _Firstname; set => _Firstname = value; }
        public string LastName { get => _Lastname; set => _Lastname = value; }
        public double CSIGrade { get => _Csigrade; set => _Csigrade = value; }
        public double GenEdGrade { get => _Genedgrade; set => _Genedgrade = value; }

        public override string ToString()
        {
            return $"Name: {_Firstname} {_Lastname} - CSI Grade: {_Csigrade} - Gen Ed Grade: {_Genedgrade}";
        }
    }
}
