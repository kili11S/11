using System;
using System.Threading;
using System.Media;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace TryPassword
{
    public partial class Form1 : Form
    {
        static byte tryes = 3;
        static int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int timer = 0;

            // Объект открытия файла
            StreamReader PasswordFile = new StreamReader("Key.txt");
            
            // Считывания данных из файла в переменную Password
            string Password = PasswordFile.ReadLine();

            // Ссылка, по которой программа переходит при неправильном вводе пароля
            again:

            Thread.Sleep(timer);
            string InputText;
            InputText = Interaction.InputBox("Введите пароль для доступа к программе \n" +
            $"*Осталось попыток: {tryes}");

            // Пароль верный
            if (InputText == Password) 
            {
                MessageBox.Show("Добро пожаловать");
            }

            // Пароль неверный
            if (InputText != Password) 
            {
                // Попытки закончились
                if (tryes == 1)       
                {
                    // Системный звук "Hand" (Зависит от версии Windows)
                    SystemSounds.Hand.Play(); 
                    this.Close();
                }

                // Попытки ещё есть
                else
                {
                    timer += 10000;
                    tryes--;
                    time += 10;
                    MessageBox.Show($"Вы ввели неверный пароль. Следующая попытка будет доступна через {time} секунд");
                    goto again;
                }
            }
            PasswordFile.Close();
        }

        // Кнопка выхода из приложения 
        // (т.к при выборе события FormClosed/Closing возникает цикл)
        private void btAppExit_Click(object sender, EventArgs e)
        {
            string ChangePasswordTextInput = Interaction.InputBox("Вы можете сменить пароль\n\n" +
                "*Оставьте это поле пустым, если хотите оставить нынешний пароль*");

            // Если пользователь не оставил поле пустым - введённые данные будут новым паролем
            if (ChangePasswordTextInput != "")
            {
                StreamWriter PasswordFile = new StreamWriter("Key.txt");
                PasswordFile.WriteLine(ChangePasswordTextInput);
                PasswordFile.Close();
                MessageBox.Show($"Вы сменили пароль на: \n {ChangePasswordTextInput}");
                PasswordFile.Close();
                this.Close();
            }

            else
            {
                this.Close();
            }
        }

        // Обработка события клика по ссылке
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открывается браузер по умолчанию и переходит по ссылке
            System.Diagnostics.Process.Start("https://goo.su/9UnU");
        }
    }
}
