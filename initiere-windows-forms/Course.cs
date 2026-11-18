using System.ComponentModel;

namespace initiere_windows_forms
{
    public class Course
    {
        private string id = string.Empty;
        private string name = string.Empty;
        private string department = string.Empty;
        private decimal price;
        private int maxStudents;
        private DateTime startDate;
        private int enrolled;

        public Course(string name, string department, decimal price, int maxStudents, DateTime startDate, int enrolled)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Department = department;
            Price = price;
            MaxStudents = maxStudents;
            StartDate = startDate;
            Enrolled = enrolled;
        }

        [Browsable(false)]
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

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must not be empty");
                }
                name = value;
            }
        }

        public string Department
        {
            get { return department; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department must not be empty");
                }
                department = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must not be negative");
                }
                price = value;
            }
        }

        public int MaxStudents
        {
            get { return maxStudents; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Max students must be greater than 0");
                }
                maxStudents = value;
            }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public int Enrolled
        {
            get { return enrolled; }
            set
            {
                if (value < 0 || value > maxStudents)
                {
                    throw new ArgumentException("Enrolled must be between 0 and max students");
                }
                enrolled = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
