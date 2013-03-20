using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SMSUI
{
    /// <summary>
    /// Interaction logic for Teacher.xaml
    /// </summary>
    public partial class Teacher : UserControl
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void addTeacherTcrBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.AddTeacher AddTeacherobj = new SMSUI.AddTeacher();

            TeacherMainUG.Children.Clear();
            TeacherMainUG.Children.Add(AddTeacherobj);
        }

        private void viewTeacherTcrBtn_Click(object sender, RoutedEventArgs e)
        {
            SMSUI.ViewTeacher ViewTeacherobj = new SMSUI.ViewTeacher();

            TeacherMainUG.Children.Clear();
            TeacherMainUG.Children.Add(ViewTeacherobj);
        }

        private void manageTcrBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
