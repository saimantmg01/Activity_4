using System;

namespace test
{

    interface IBook
    {
        // properties
        string Book_name { get; set; }
        string Book_genre { get; set; }
        string Author_name { get; set; }
        int Book_price { get; set; }

        //methods
        void Getbook_name();
        void Getbook_price();
        void Getbook_author();
        void Getbook_genre();
    }

    class Implements_book : IBook
    {
        //default values- fields
        private string name = "The Great Gatsby";
        private string genre = "Historical Fiction";
        private string author = "F. Scott Fitzgerald";
        private int price = 7;
        //properties
        public string Book_name { get => name; set => Book_name = value; }
        public string Book_genre { get => genre; set => Book_genre = value; }
        public string Author_name { get => author ; set => Author_name = value; }
        public int Book_price { get => price; set => Book_price = value; }

        //instance methods
        public void Getbook_author()
        {
            Console.WriteLine($"The book author name is {Author_name}");
        }

        public void Getbook_name()
        {
            Console.WriteLine($"The book name is {Book_name}");
        }

        public void Getbook_price()
        {
            Console.WriteLine($"The book price is {Book_price}");
        }
        public void Getbook_genre()
        {
            Console.WriteLine($"The book genre is {Book_genre}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Implements_book book1 = new Implements_book();
            book1.Getbook_author();
            book1.Getbook_name();
            book1.Getbook_price();
            book1.Getbook_genre();
        }
    }
}
