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
    /// Interaction logic for ExtraViaPropWindow.xaml
    /// </summary>
    public partial class ExtraViaPropWindow : Window
    {
        public string DataText
        {
            set
            {
                this.Title = value;
            }
        }

        public ExtraViaPropWindow()
        {
            InitializeComponent();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    this.Title = this.DataText;
        //}
    }
}
