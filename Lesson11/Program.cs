namespace Homework
{
    class School
    {
        public static void Main()
        {
            Classroom a = new Classroom();
            Console.WriteLine("People:");
            a.Students();
            Console.WriteLine("Новий однокласник:");
            a.NewStudent = "Олександер Маслов\n";
            Console.WriteLine(a.NewStudent);

            Student student = new Student();
            Console.WriteLine(student.StudentGreeting("Привіт," + " "));
            Console.WriteLine("\n");

            Shedule b = new Shedule();
            Console.WriteLine("Standart Shedule:");
            b.StandartShedule();
            Console.WriteLine("\n");

            Teacher c = new Teacher();
            Console.WriteLine("Інформація про вчетелів:");
            c.TeachersInfo();
        }
    }
    class Classroom
    {
        private string NewStudents;
        public string NewStudent
        {
            get { return NewStudents; }
            set { NewStudents = value; }
        }
        public void Students()
        {
            string[] People = new string[]
            {
                "Білошапка Іван",
                "Солодовник Юрій",
                "Гуляев Анатолий"
            };

            foreach (var k in People)
            {
                Console.WriteLine(k);
            }
        }
    }

    class Student
    {
        public string StudentGreeting(string message)
        {
            Console.WriteLine("Привіт, як тебе звуть");
            string Name = Console.ReadLine();
            return message + Name;
        }
    }
    class Shedule
    {
        public void StandartShedule()
        {
            string[] SheduleArray = new string[]
            {
            "Понеділок - 13:30 - Укр.мов.",
            "Вівторок - 10:00 - Математика",
            "Среда - 11:30 - Фізика",
            "Четверг - 12:45 - Алгебра",
            "П'ятниця - 9:00 - Біология"
            };

            foreach (var i in SheduleArray)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Teacher
    {
        public void TeachersInfo()
        {
            string[] Teachers = new string[]
            {
            "Фізика - Ніна Миколаевна",
            "Математика - Анастасія Юрівна",
            "Укр.мов - Татяна В'ячеславовна",
            "Біология - Полина Ігорівна"
            };

            foreach (var j in Teachers)
            {
                Console.WriteLine(j);
            }
        }
    }
}

//checked




