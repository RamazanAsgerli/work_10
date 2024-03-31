using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1234
{
    internal class Student
    {
        private string _fullname;
        public string GroupNo;
        public byte AvgPoint;

        public string FullName
        {
            get { return _fullname; }
            set
            {
                if (value != null)
                {
                    _fullname = value;
                }
                else
                {
                    Console.WriteLine("Student yaradila bilmez");
                }
            }
        }

        public Student(string fullname, string groupno, byte point)
        {
            FullName = fullname;
            GroupNo = groupno;
            AvgPoint = point;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"FullName: {_fullname}\nGroupNo: {GroupNo}\nAvgPoint: {AvgPoint}");
        }

    }
}
