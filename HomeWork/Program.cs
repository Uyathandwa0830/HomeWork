using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

class Book
{
    private string? name;
    private string? email;
    private long id;
    private int year;
    private readonly string author;
    private readonly string title;
    private readonly int bookId;

    //ADD CONSTRUCTOR
    public Book(string name, string email, long id)
    {
        this.name = name;
        this.email = email;
        this.id = id;
    }
    //ADD METHOD
    public void UserInput(string name, string email, long id)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }
    //Display user
    public string DisplayUser(User user)
    {
        return $"User ID:{this.id}\nName:{this.name}\n Email:{this.email}";
    }

    class Books
    {
        private int bookId;
        private string? title;
        private string? author;
        private int year;
        //class constructor
        public Books(int bookId, string title, string author, int year)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.year = year;
        }
        //ADD BOOK METHOD
        public void AddBook(int id, string title, string author, int year)
        {
            this.bookId = id;
            this.title = title;
            this.author = author;
            this.year = year;
        }
        //UPDATE METHOD
    }

    public void Update(Books book)
    {
        int NewId = this.bookId;
        string NewTitle = this.title;
        string NewAuthor = this.author;
        int NewYear = this.year;

    }
    //Remove method
    public void removeBook(Books book)
    {
        this.bookId = 0;
        this.title = null;
        this.author = null;
        this.year = 0;
    }
    //Display
    public string DisplayBook(Books book)
    {
        return $"Book Details:\nBook ID:{this.bookId}\nTitle:{this.title}\nAuthor:{this.author}\nYear:{year}";
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Library Management System \n" +
                "1.Add Book\n" +
                "2.Update Book\n" +
                "3.Remove Book\n" +
                "4.Add User\n" +
                "5.Display All Books\n" +
                "6.Display All Users\n" +
                "7.Exit");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.Write("Enter Book Id:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter book tittle:");
                string? booktittle = Console.ReadLine();
                Console.WriteLine("Enter the year of when the book was published");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Author:");
                string? author = Console.ReadLine();
                Book books = new Book(y, booktittle, author, year);
                books.DisplayBooks();
            }
            else if (x == 2)
            {
                Console.WriteLine("What would you like to update\n" +
                    "1.Id\n" +
                    "2.Title\n" +
                    "3.Year\n" +
                    "4.Author\n" +
                    "Enter number:");
                int update = Convert.ToInt32(Console.ReadLine());
                if (update == 1)
                {

                }

            }

        }
        while (true);
    }
}








