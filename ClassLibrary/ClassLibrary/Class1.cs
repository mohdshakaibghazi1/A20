﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Library
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
    }
}
