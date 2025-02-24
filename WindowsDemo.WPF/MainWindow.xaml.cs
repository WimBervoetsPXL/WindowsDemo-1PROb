using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsDemo.WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        //string data = dataTextBox.Text;
        //ExtraWindow extraWindow = new ExtraWindow(data);
        ////extraWindow.ShowInTaskbar = false;
        //extraWindow.Show();


        //ExtraViaPropWindow propWindow = new ExtraViaPropWindow();
        //propWindow.DataText = dataTextBox.Text;
        //propWindow.Show();


        Data.DataText = dataTextBox.Text;

        ExtraViaDataWindow window = new ExtraViaDataWindow();
        window.Show();
    }

    private void studentButton_Click(object sender, RoutedEventArgs e)
    {
        Student student = new Student(firstNameTextBox.Text, lastNameTextBox.Text);
        student.FirstName = firstNameTextBox.Text;
        student.StudentNumber = studentNumberTextBox.Text;



        //StudentWindow window = new StudentWindow(student);
        //window.Show();

        //StudentWindow window = new StudentWindow();
        //window.Student = student;
        //window.Show();

        Data.Student = student;

        StudentViaDataWindow w = new StudentViaDataWindow();
        w.Show();

    }
}