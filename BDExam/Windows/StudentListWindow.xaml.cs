using BDExam.StudentListModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для StudentListWindow.xaml
    /// </summary>
    public partial class StudentListWindow : Window
    {
        StudentListContext db;

        public StudentListWindow()
        {
            InitializeComponent();
            db = new StudentListContext();
            db.Student.Load();
            students_grid.ItemsSource = db.Student.Local.ToBindingList();
            this.Closing += StudentListWindows;
        }

        private void StudentListWindows(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (students_grid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < students_grid.SelectedItems.Count; i++)
                {
                    Student student = students_grid.SelectedItems[i] as Student;
                    if (student != null)
                    {
                        db.Student.Remove(student);
                    }
                }
            }
            db.SaveChanges();
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            Windows.MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();
        }
    }
}
