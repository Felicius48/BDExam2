using BDExam.AdminPanelModel;
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
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        AdminPanelContext db;

        public AdminPanel()
        {
            InitializeComponent();
            db = new AdminPanelContext();
            db.adminPanels.Load();
            this.Closing += StudentListWindows;
        }
        private void StudentListWindows(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
