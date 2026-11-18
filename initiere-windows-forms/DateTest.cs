namespace initiere_windows_forms
{
    public static class DateTest
    {
        public static List<Student> Students()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Maria", "Popescu", "maria.popescu@mail.ro", "maria123", 17));
            students.Add(new Student("Andrei", "Ionescu", "andrei.ionescu@mail.ro", "andrei123", 21));
            students.Add(new Student("Elena", "Dumitru", "elena.dumitru@mail.ro", "elena123", 16));
            students.Add(new Student("Radu", "Stan", "radu.stan@mail.ro", "radu123", 25));
            students.Add(new Student("Ioana", "Marin", "ioana.marin@mail.ro", "ioana123", 19));
            students.Add(new Student("Vlad", "Georgescu", "vlad.georgescu@mail.ro", "vlad123", 15));
            students.Add(new Student("Teodora", "Radu", "teodora.radu@mail.ro", "teodora123", 22));
            return students;
        }

        public static List<Course> Courses()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course("Introducere în C#", "Programare", 450m, 20, new DateTime(2026, 11, 2), 18));
            courses.Add(new Course("SQL pentru începători", "Baze de date", 380m, 15, new DateTime(2026, 11, 9), 15));
            courses.Add(new Course("Python de la zero", "Programare", 420m, 25, new DateTime(2026, 12, 7), 25));
            courses.Add(new Course("Algebră clasa a IX-a", "Matematică", 300m, 12, new DateTime(2026, 12, 14), 4));
            courses.Add(new Course("Web cu HTML și CSS", "Web", 400m, 18, new DateTime(2027, 1, 11), 10));
            courses.Add(new Course("Algoritmi și structuri de date", "Informatică", 520m, 10, new DateTime(2027, 1, 25), 10));
            courses.Add(new Course("Geometrie clasa a X-a", "Matematică", 320m, 14, new DateTime(2027, 2, 8), 0));
            return courses;
        }
    }
}
