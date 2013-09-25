using System;
using System.Linq;
using System.Collections.Generic;

class DeckOfCards
{
    public List<Card> Cards = new List<Card>();
    public static List<string> Types = new List<string>() {"Hjärter", "Spader", "Klöver", "Ruter" };

    public void createDeckOfCards()
    { 
        for(int i = 1; i < 53; i++)
        {
            switch (i)
            {
                case (1):
                    {
                        if (i < 14)
                            Cards.Add(new Card(Types[0], i));
                        break;
                    };
                case (2):
                    {
                        if (i > 13 && i < 27)
                            Cards.Add(new Card(Types[1], i - 13));
                        break;
                    };
                case (3):
                    {
                        if (i > 26 && i < 40)
                            Cards.Add(new Card(Types[2], i - 26));
                        break;
                    }
                case (4):
                    {
                        if (i > 39)
                            Cards.Add(new Card(Types[3], i - 39));
                        break;
                    }
            }
        }
    }
}

