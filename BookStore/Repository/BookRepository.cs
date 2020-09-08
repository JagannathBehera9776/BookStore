using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModels> GetAllBooks()
        {
            return DataSource();
        }
        public BookModels GetBookId(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModels> DataSource()
        {
            return new List<BookModels>()
            {
                new BookModels{Id=1,Title="MVC",Author="Jagannath",Description="This is MVC Book",Category="Programing",Language="English",TotalPages=107},
                new BookModels{Id=1,Title="C#",Author="Chinyu",Description="This is C# Book",Category="Programing",Language="English",TotalPages=107},
                new BookModels{Id=1,Title="English",Author="Behera",Description="This is English Book",Category="Programing",Language="English",TotalPages=107},
            };
        }
    }
}
