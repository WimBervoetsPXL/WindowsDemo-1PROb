using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemo.WPF
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }

        private List<int> _grades;

        public List<int> Grades
        {
            get { 
                return _grades; 
            }
            set 
            {
                _grades = value; 
            }
        }

        public Student()
        {
            _grades = new List<int>();
        }

        public Student(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
