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
using System.Collections.ObjectModel;

namespace SusmitaExcercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();  
        }
    }

     public class SubjectAndMarks 
{
    public string Subject { get; set; }
    public double Marks { get; set; }
}
public class Student 
{
    public string Name { get; set; }
    public int RollNo { get; set; }
    public ObservableCollection<SubjectAndMarks> SubjectAndMarks { get; set; }
}

public class ViewModel //ViewModel
{
     public ObservableCollection<Student> Students { get; set; }
    public ViewModel()
    {
        Students = new ObservableCollection<Student>();
        Students.Add(new Student()
        {
            Name = "Harish",
            RollNo = 1,
            SubjectAndMarks = new ObservableCollection<SubjectAndMarks>()
        {new SubjectAndMarks(){Subject="Maths",Marks=100},new SubjectAndMarks(){Subject="Hindi",Marks=100},
        new SubjectAndMarks(){Subject="Science",Marks=100}}
        });
        Students.Add(new Student()
        {
            Name = "Pankaj",
            RollNo = 2,
            SubjectAndMarks = new ObservableCollection<SubjectAndMarks>()
        {new SubjectAndMarks(){Subject="Maths",Marks=100},new SubjectAndMarks(){Subject="Hindi",Marks=40},
        new SubjectAndMarks(){Subject="Science",Marks=30}}
        });
        Students.Add(new Student()
        {
            Name = "Deepak",
            RollNo = 3,
            SubjectAndMarks = new ObservableCollection<SubjectAndMarks>()
        {new SubjectAndMarks(){Subject="Maths",Marks=90},new SubjectAndMarks(){Subject="Hindi",Marks=50},
        new SubjectAndMarks(){Subject="Science",Marks=60}}
        });
    } 
}
   
}
