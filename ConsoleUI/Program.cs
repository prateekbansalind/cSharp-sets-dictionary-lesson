using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // how to use dictonary data type

            Dictionary<int, string> events = new Dictionary<int, string>();

            // Dictionary has an concept of key and value
            // Dictionary can not have same key.

            events[1991] = "I born in this year";
            events[2016] = "I went to USA";
            events[2019] = "I got married";
            events[2021] = "I came to New Zealand";

            Console.WriteLine($"In 2019, {events[2019]}.");

            Console.ReadLine();
        }
    }
}