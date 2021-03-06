﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private List<Book> books;

        public BookCatalog()
        {
            books = new List<Book>();
        }

        public void AddBook(Book aBook)
        {
            books.Add(aBook);

             
            
            // Add code that can add the given Book object to the list
        }

        public void PrintAllBooks()
        {
            foreach(Book printBooks in books)
            {
                Console.WriteLine($"{printBooks.GetAllInformation()}");
            }

            //books.ForEach(i => Console.Write("{0} \n", i));
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            foreach(Book matchingISBN in books)
            {
                

                if (isbn == matchingISBN.GetISBN())
                {
                    matchingBook = matchingISBN;
                }
               
            }
            return matchingBook;
            // Book matchingISBN = books.Find(x => x.GetISBN() == isbn); // not working, develop new method.

            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You will need a repetition statement


        }
    }
}
