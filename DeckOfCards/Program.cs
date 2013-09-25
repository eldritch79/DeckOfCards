using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        DeckOfCards test = new DeckOfCards();
        test.createDeckOfCards();
        foreach (var item in test.Cards)
        Console.WriteLine("Type: " + item.Type + " Number: " + item.Number);
    }
}
