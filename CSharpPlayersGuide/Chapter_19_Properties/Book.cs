using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_Properties
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; } = 0;
        public int WordCount { get; set; } = 0;

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
        public Book(string title, string author, int pages, int wordCount)
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.WordCount = wordCount;
        }

        public void AssignWordCountFromText(string text) { WordCount = text.Split(' ').Length; }


    }
    
}
