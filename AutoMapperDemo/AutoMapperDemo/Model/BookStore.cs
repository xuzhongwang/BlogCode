﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperDemoTest.Model
{
    public class BookStore
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Address Address { get; set; }
    } 
}
