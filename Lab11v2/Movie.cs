using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11v2
{
    public abstract class Movie
    {

        //public string Title { get; set; }
        //public string Category { get; set; }

        private string _title;
        private string _category;
        public string Title { get => _title; set => _title = value; }
        public string Category { get => _category; set => _category = value; }
    }
}
