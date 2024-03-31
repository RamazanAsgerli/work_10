using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1234
{
    internal class Group
    {
        public Student[] Students = { };

        private string _no;
        private byte _studentlimit;

        public string No
        {
            get { return _no; }
            set
            {
                if (value.Length == 5 && (value[0] >= 'A' && value[0] <= 'Z') && (value[1] >= 'A' && value[1] <= 'Z') && (value[2] >='0' && value[2] <= '9') && (value[3] >= '0' && value[3] <= '9') && (value[4] >= '0' && value[4] <= '9') )
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("Nomreni duzgun daxil edin!!!");
                }
            }
        }

        public byte StudentLimit
        {
            get { return _studentlimit; }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    _studentlimit = value;
                }
                else
                {
                    Console.WriteLine("Student sayi doludu");
                }
            }
        }
        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Qrupdakı telebe limiti dolub!");
            }

        }

        public Student[] GetAllStudents()
        {
            return Students;
        }

        public Student[] GetAllStudentsFullName(string searchFullName)
        {
            Student[] students = { };
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].FullName.Contains(searchFullName))
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = Students[i];
                }
            }

            return students;
        }
    }
}
