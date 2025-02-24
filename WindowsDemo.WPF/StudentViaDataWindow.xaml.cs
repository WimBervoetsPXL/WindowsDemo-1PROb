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
    /// Interaction logic for StudentViaDataWindow.xaml
    /// </summary>
    public partial class StudentViaDataWindow : Window
    {
        public StudentViaDataWindow()
        {
            InitializeComponent();

            firstNameLabel.Content = Data.Student.FirstName;
            lastNameLabel.Content = Data.Student.LastName;
            studentNumberLabel.Content = Data.Student.StudentNumber;
        }
    }
}
