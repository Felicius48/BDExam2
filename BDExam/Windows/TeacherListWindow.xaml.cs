using BDExam.TeacherListModels;
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
    /// Логика взаимодействия для TeacherListWindow.xaml
    /// </summary>
    public partial class TeacherListWindow : Window
    {
        TeacherListContext db;

        public TeacherListWindow()
        {
            InitializeComponent();
            db = new TeacherListContext();
            db.Teacher.Load();
            teacher_grid.ItemsSource = db.Teacher.Local.ToBindingList();
            this.Closing += TeacherListWindows;
        }

        private void TeacherListWindows(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (teacher_grid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < teacher_grid.SelectedItems.Count; i++)
                {
                    Teacher teacher = teacher_grid.SelectedItems[i] as Teacher;
                    if (teacher != null)
                    {
                        db.Teacher.Remove(teacher);
                    }
                }
            }
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            this.Close();
        }
    }
}
