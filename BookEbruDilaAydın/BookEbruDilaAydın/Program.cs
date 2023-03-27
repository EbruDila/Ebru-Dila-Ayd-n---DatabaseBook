// See https://aka.ms/new-console-template for more information
using BookEbruDilaAydın.Models;
Console.WriteLine("Hello, World!");

Books Books = new Books()
{
    Id = 1,
    Name = "Çalıkuşu",
    Publisher = 1,
    PublishingTime = new DateTime(1993,01,01)
};

BookDatabase BookDatabase = new BookDatabase();
BookDatabase.Books.Add(Books);
BookDatabase.SaveChanges();

var books = BookDatabase.Books.Where(s=>s.Id==1).FirstOrDefault();
Books.Publisher = 2;
BookDatabase.SaveChanges();

if(Books.Id==1)
{
    BookDatabase.Books.Remove(Books);
    BookDatabase.SaveChanges();
}
else
{
    Console.WriteLine("No Books");
}

Publishers Publishers = new Publishers()
{
    Id = 1,
    Name = "İnkılap Yayınevi",
    books = "Çalıkuşu"
};
BookDatabase.Publishers.Add(Publishers);
BookDatabase.SaveChanges();