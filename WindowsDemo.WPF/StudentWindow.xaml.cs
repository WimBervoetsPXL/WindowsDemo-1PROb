using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WindowsDemo.WPF
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        public StudentWindow(Student student) : this()
        {
            firstNameLabel.Content = student.FirstName;
            lastNameLabel.Content = student.LastName;
            studentNumberLabel.Content = student.StudentNumber;
        }

        public Student Student
        {
            set {
                firstNameLabel.Content = value.FirstName;
                lastNameLabel.Content = value.LastName;
                studentNumberLabel.Content = value.StudentNumber;
            }
        }

    }
}
