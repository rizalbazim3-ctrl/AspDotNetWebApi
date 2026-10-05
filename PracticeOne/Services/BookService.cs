using Microsoft.AspNetCore.Mvc;
using PracticeOne.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PracticeOne.Services
{
    public class BookService
    {
        public static List<Book> books = new List<Book>();
        public void add(Book data)
        {
            books.Add(data);
        }

        public void dlt(int id)
        {
            books.RemoveAll(item => id == item.Id);
        }

        public void edit(int id, Book data)
        {

            var book = books.Find(item => id == item.Id);

            book?.Id = data.Id;
            book?.Title = data.Title;
            book?.Price = data.Price;
        }
        }
}