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

namespace BDExam.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

   

        private void StudentList_Click(object sender, RoutedEventArgs e)
        {
            Windows.StudentListWindow studentListWindow = new Windows.StudentListWindow();
            studentListWindow.Show();
            this.Close();
        }

        private void TeacherList_Click(object sender, RoutedEventArgs e)
        {
            TeacherListWindow teacherListWindow = new TeacherListWindow();
            teacherListWindow.Show();
            this.Close();
        }

        private void admin_panels_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaleList_Click(object sender, RoutedEventArgs e)
        {
            SalePanel panel = new SalePanel();
            panel.Show();
            this.Close();
        }
    }
}
