namespace task1234
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string _no;
            string studentLimitStr;
            byte _studentlimit;

            do
            {
                Console.WriteLine("Qrup nomresi daxil edin:");
                _no = Console.ReadLine();
            } while (_no.Length != 5);

            do
            {
                Console.WriteLine("Limit daxil edin");
                studentLimitStr = Console.ReadLine();
            } while (!byte.TryParse(studentLimitStr, out _studentlimit));
            Group group = new Group();
            group.No = _no;
            group.StudentLimit = _studentlimit;



            bool check = true;


            do
            {
                Console.WriteLine("1. Telebe elave et" +
                                  "\n2. Butun telebelere bax" +
                                  "\n3. Telebeler uzre axtariş et" +
                                  "\n0. Proqrami bitir");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":


                        Console.WriteLine("Telebenin tam adini daxil et:");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Qrupun nomresini daxil et:");
                        string groupno = Console.ReadLine();

                        string AvgPoint;
                        byte point;
                        do
                        {
                            Console.WriteLine("Ortalama bali daxil et:");
                            AvgPoint = Console.ReadLine();

                        } while (!byte.TryParse(AvgPoint, out point) && point > 0 && point < 100);
                        Student student = new Student(fullname, groupno, point);
                        group.AddStudent(student);
                        break;

                    case "2":
                        Student[] students = group.GetAllStudents();
                        for (int i = 0; i < students.Length; i++)
                        {
                            students[i].ShowStudentInfo();
                        }
                        break;

                    case "3":

                        string searchFullName;
                        do
                        {
                            Console.WriteLine("Ad daxil et:");
                            searchFullName = Console.ReadLine();

                        } while (searchFullName == null);

                        Student[] FilteredStudents = group.GetAllStudentsFullName(searchFullName);

                        for (int i = 0; i < FilteredStudents.Length; i++)
                        {
                            FilteredStudents[i].ShowStudentInfo();
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun eded daxil edin!!!");
                        break;
                }
            } while (check);

        }
    }
}
