using BDExam.AutDataModel;
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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        AutDataContext db;

        public RegWindow()
        {
            InitializeComponent();
            db = new AutDataContext();
            db.autData.Load();
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            if (db.autData.Any(x => x.Login == user_Login.Text))
            {
                MessageBox.Show("Данный пользователь уже существует");
            }
            else
            {
                AutData autData = new AutData()
                {
                    Login = user_Login.Text,
                    Password = user_Password.Password
                };
                db.autData.Add(autData);
                db.SaveChanges();
                MessageBox.Show("успех");
            }
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
