namespace initiere_windows_forms
{
    public class Student
    {
        private string id = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string email = string.Empty;
        private int age;
        private string password = string.Empty;

        public Student(string firstName, string lastName, string email, string password, int age)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Age = age;
        }

        public string Id
        {
            get { return id; }
            set
            {
                if (!Guid.TryParse(value, out _))
                {
                    throw new ArgumentException("Id must be a valid Guid");
                }
                id = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name must not be empty");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name must not be empty");
                }
                lastName = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email must not be empty");
                }
                email = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be greater than 0");
                }
                age = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Password must not be empty");
                }
                password = value;
            }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + Email;
        }
    }
}
