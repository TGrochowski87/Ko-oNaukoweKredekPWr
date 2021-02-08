using System;
using System.Linq;
using CPC2020_2_Lab4.Models.Entities;
using CPC2020_2_Lab4.Repositories.Interfaces;

namespace CPC2020_2_Lab4.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    public class UsersRepository : Repository, IUsersRepository
    {
        /// <summary>
        /// Metoda sprawdzająca czy można się zalogować do aplikacji na podstawie login i password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string login, string password)
        {
            User user = DbContext.Users.SingleOrDefault(u => u.Login == login && u.Password == password);
            return user != null;
        }

        /// <summary>
        /// Metoda dodająca dodająca opcje 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Register(string login, string password)
        {
            //tworzym ksiązke któóra zostaje dodana
            User userToAdd = new User()
            {
                Login = login,
                Password = password
            };

            //sprawdzamy czy istnieje taki użytkownik w bazie
            User foundedUser = DbContext.Users.FirstOrDefault(u => u.Login == login);
            if (foundedUser != null)
                return false;

            //możemy to zrobić alternatywnie, w modelu User nałożyć na login adnotacje 'unique' i wtedy przy zapisywaniu do bazy zostanie zwrócony błąd ponieważ login się powtórzył i baza zwróci błąd

            //dodajem użytkownika do bazy danych
            DbContext.Users.Add(userToAdd);

            //zapisujemy i zwracamy czy zapytanie rpzebiegło pomyslnie
            return DbContext.SaveChanges() > 0;
        }
    }
}