using BDExam.Windows;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BDExam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AutDataModel.AutDataContext db;
        

        public MainWindow()
        {
            InitializeComponent();
            db = new AutDataModel.AutDataContext();
            db.AutDatas.Load();

        }


        private void btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            if (db.AutDatas.Any(x => x.Login == userLogin.Text && x.Password == userPassword.Password && x.IdRole == 1))
            {
                
                    MessageBox.Show("Привет Админ!");
                    Windows.MenuWindow menuWindow = new Windows.MenuWindow();
                    menuWindow.Show();
                    this.Close();
            }
            if (db.AutDatas.Any(x => x.Login == userLogin.Text && x.Password == userPassword.Password && x.IdRole == 2))
            {
                MessageBox.Show("Привет Пользователь!");
                Windows.MenuWindow menuWindow = new Windows.MenuWindow();
                menuWindow.Show();
                this.Close();
            }
            else 
                MessageBox.Show("Логин и Пароль не найдены!");
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
        }
    }
}
