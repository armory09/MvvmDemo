using System.Windows;
using MvvmDemo.ViewModel;

namespace MvvmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewModel studentViewModelObject = new StudentViewModel();

            studentViewModelObject.LoadStudents();

            StudentViewControl.DataContext = studentViewModelObject;
        }
    }
}
