﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.Showstatistics();
        }
    }
}

