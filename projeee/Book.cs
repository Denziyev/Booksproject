

namespace projeee
{
    internal class Book
    {
        string _name;
        int _pageCount;

        public string Name 
        { get=>  _name;
            set
            {
                    _name = value;               
            }
        }
        public int PageCount
        {
            get => _pageCount;
            set
            {             
                    _pageCount = value;          
            }
        }
        public Book(string Name, int PageCount)
        {
            this.Name = Name;   
            this.PageCount = PageCount; 
        }
        public Book() { }

        int bookLimit = 3;
         public void createbook(ref Book[] books)
        {
            for(int i=0; i<bookLimit;)
            {
                Console.WriteLine("Enter Book Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Book page ");
                int PageCount = int.Parse(Console.ReadLine());
                if (searchbook(books, Name, PageCount))
                {
                    Console.WriteLine("Artiq movcuddur");
                }
                else if (PageCount >= 10 && Name.Length > 2)
                {
                    Array.Resize(ref books, books.Length + 1);
                    Book bookss = new Book(Name, PageCount);
                    books[books.Length - 1] = bookss;
                    i++;

                }
                else
                {
                    Console.WriteLine("Kitab adı 2 herfden çox olmalı ve sehife sayi 9 dan cox olmali");
                }
            }
            
        }
        public bool searchbook(Book[] books,string Name, int PageCount)
        {
            bool status = false;
            for (int i=0; i<books.Length; i++)
            {
                
                if (books[i].Name == Name&& books[i].PageCount==PageCount) 
                {
                    status= true;
                    break;
                }
               
            }
            return status;
        }
        public void ShowBooks(ref Book[] books)
        { 
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"BOOK {i + 1} Name: {books[i].Name} BOOK {i + 1} Page: {books[i].PageCount} ");
            }
        }

        
    }
}
