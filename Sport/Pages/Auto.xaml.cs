using HashPassword;
using Sport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Sport.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        public Auto()
        {
            InitializeComponent();
            txtboxCaptcha.Visibility = Visibility.Hidden;
            txtBlockCaptcha.Visibility = Visibility.Hidden;


        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }

        private int countUnsuccessfull = 0;




        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            Class1 hasher = new Class1();
            Polizovateli users = new Polizovateli();
            DanniePersonal employee= new DanniePersonal();

            string login = txtbLogin.Text.Trim();
            string password = pswbPassword.Password.Trim();
            if (login.Length > 0 && password.Length > 0)
            {
                if (countUnsuccessfull < 1)
                {

                    string hashingpasword = hasher.HashingPassword(password);
                    var user = Helper.GetContext().Polizovateli.Where(u => u.LoginPolizovateli == login && u.ParoliPolizovateli == hashingpasword).FirstOrDefault();
                    if (user != null)
                    {
                        var employei = Helper.GetContext().DanniePersonal.FirstOrDefault(emp => emp.KodPersonal == user.KodPolizovatieli);
                        if (employei != null && employei.Doljnosti != 0)
                        {
                            switch (employei.Doljnosti)
                            {
                                case 1:
                                    NavigationService.Navigate(new Pages.Admin());
                                    break;

                                case 2:
                                    NavigationService.Navigate(new Pages.Menedjer());
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пользователя с таким логином или паролем не существует!", "Внимание", MessageBoxButton.OK);
                            countUnsuccessfull++;

                            GenerateCaptcha();
                        }
                    }
                }
                else
                {
                    string hashingpasword = hasher.HashingPassword(password);
                    var user = Helper.GetContext().Polizovateli.Where(u => u.LoginPolizovateli == login && u.ParoliPolizovateli == hashingpasword).FirstOrDefault();
                    string captcha = txtboxCaptcha.Text.Trim();
                    if (user != null && captcha == txtBlockCaptcha.Text)
                    {
                        txtboxCaptcha.Visibility = Visibility.Visible;
                        txtBlockCaptcha.Visibility = Visibility.Visible;
                        txtboxCaptcha.Text = "";
                        txtBlockCaptcha.Text = "";
                        countUnsuccessfull = 0;
                    }
                    else
                    {
                        MessageBox.Show("Капча введена неправильно, попробуйте ещё раз!", "Внимание", MessageBoxButton.OK);
                        countUnsuccessfull++;
                        GenerateCaptcha();


                    }

                }
            }
            else
            {
                MessageBox.Show("Не все поля были заполнены! Заполните логин и пароль, и повторите попытку авторизации!", "Внимание", MessageBoxButton.OK);
            }

        }
        private void GenerateCaptcha()
        {
            txtboxCaptcha.Visibility = Visibility.Visible;
            txtBlockCaptcha.Visibility = Visibility.Visible;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string captcha = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            txtBlockCaptcha.Text = captcha;
            txtBlockCaptcha.TextDecorations = TextDecorations.Strikethrough;
        }

    }

    
}
