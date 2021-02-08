using System.Collections.Generic;
using CPC2020_2_Lab4.Models.Entities;
using CPC2020_2_Lab4.ViewModels;

namespace CPC2020_2_Lab4.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    public interface IBooksRepository
    {
        /// <summary>
        /// Abstrakcyjna metoda do pobierania wszystkich książek z tabeli Books
        /// </summary>
        /// <returns></returns>
        List<BookViewModel> GetBooks();

        /// <summary>
        /// Abstrakcyjna metoda do pobierania wszystkich książek z tabeli Books
        /// </summary>
        /// <returns></returns>
        List<BookSimpleViewModel> GetBooksSimpleViewModel();

        /// <summary>
        /// Abstrakcyjna metoda do pobierania książki o podanym id
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Book GetBookById(int id);

        /// <summary>
        /// Abstrakcyjna metoda do dodawania nowej książki do tabeli Books
        /// </summary>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        bool AddBook(string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName);

        /// <summary>
        /// Abstrakcyjna metoda do usuwania książki z tabeli Books na podstawie bookId
        /// </summary>
        /// <param name="bookId"></param>
        bool DeleteBook(int bookId);

        /// <summary>
        /// Abstrakcyjna metoda do aktualizacji książki z tabeli Books
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        bool EditBook(int bookId, string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName);
    }
}
