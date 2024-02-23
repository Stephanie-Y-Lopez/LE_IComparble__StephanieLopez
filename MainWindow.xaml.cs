using System.Security.Cryptography.X509Certificates;
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

namespace LE_IComparble__StephanieLopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> GetStudents = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
            PreLoadList();
            DisplayStudent(GetStudents, Lb_Student);
            RB_ASD.IsChecked = true;
        }

        void PreLoadList()
        {
            GetStudents.Add(new Student("Yolis", "Chavoya"));
            GetStudents.Add(new Student("Oswaldo", "Mendez"));
            GetStudents.Add(new Student("Daisy", "Chavoya"));
            GetStudents.Add(new Student("Diana", "Garcia"));
            GetStudents.Add(new Student("Pedro", "Campos"));
            GetStudents.Add(new Student("Yolanda", "Chavoya"));
        }

        public void DisplayStudent(List<Student> studentlist, ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (Student student in studentlist)
            {
                listBox.Items.Add(student);
            }
        }

        private void B_Name_Click(object sender, RoutedEventArgs e)
        {
            GetStudents.Sort();
            DisplayStudent(GetStudents, Lb_Student);
        }

        private void B_CSI_Click(object sender, RoutedEventArgs e)
        {
            Student_SortCsigradeDsc studentsort = new Student_SortCsigradeDsc();
            GetStudents.Sort(studentsort);
            DisplayStudentinfo();
        }

        private void B_GenEd_Click(object sender, RoutedEventArgs e)
        {
            Student_SortGenedgrade.SortingOrder order = Student_SortGenedgrade.SortingOrder.Ascending;

            if(!RB_ASD.IsChecked.Value)
            {
                order = Student_SortGenedgrade.SortingOrder.Descending;
            }

            Student_SortGenedgrade genedgrade = new Student_SortGenedgrade(order);
            GetStudents.Sort(genedgrade);
            DisplayStudentinfo();
        }

        public void DisplayStudentinfo()
        {
            DisplayStudent(GetStudents, Lb_Student);
        }

        public void SortEx()
        {
            Student_SortCsigradeDsc sortCsigradeAsc = new Student_SortCsigradeDsc();
            Student_SortGenedgrade sortGenedgrade = new Student_SortGenedgrade(Student_SortGenedgrade.SortingOrder.Descending);

            GetStudents.Sort(sortGenedgrade);
        }
        ////Answering Questions: 
        //1. IComparable : is used for providing sorting order for objects. While IComparer: Is used to compare objects that do not implement IComparable.
        //2. It runs into 1, 0, and -1. 
        //3. sort().
        //4. It signifies the type of object you will compare it to.

    }
}