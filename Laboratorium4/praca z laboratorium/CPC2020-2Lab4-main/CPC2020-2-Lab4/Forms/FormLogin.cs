using CPC2020_2_Lab4.Repositories;
using System;
using System.Windows.Forms;

namespace CPC2020_2_Lab4.Forms
{
    /// <summary>
    /// Okno do logowania
    /// </summary>
    public partial class FormLogin : Form
    {
        private UsersRepository userRepository = new UsersRepository();

        /// <summary>
        /// Konstruktor okna do logowania
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();

            //Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            //wywołujemy funkcje logowania i wyświetlamy komunikat jeśli nie udało się zalogować, jeśli się udało przechodzimy dookna książek
            if (userRepository.Login(login, password))
            {
                Program.Logged = true;
                Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            //wywołujemy metode rejestracji i wyświetlamy stosowny komunikat w zależności d tego co zwraca
            if (userRepository.Register(login, password))
            {
                MessageBox.Show("Konto zostało utworzone, możesz się teraz zalogować");
            }
            else
            {
                MessageBox.Show("Taki użytkownik już istnieje");
            }
        }
    }
}