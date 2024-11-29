using System;
using System.Collections.Generic;

partial class Program
{
    static void PrintDeck(List<Card> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            if (cards[i].color == CardColor.BLACK)
            {
                Console.Write("0");
            }
            else if (cards[i].color == CardColor.RED)
            {
                Console.Write("R");
            }
            else if (cards[i].color == CardColor.GREEN)
            {
                Console.Write("G");
            }
            else if (cards[i].color == CardColor.BLUE)
            {
                Console.Write("B");
            }
            else if (cards[i].color == CardColor.YELLOW)
            {
                Console.Write("Y");
            }
            else
            {
                Console.Write("?");
            }
            if (cards[i].type >= CardType.ZERO && cards[i].type <= CardType.NINE)
            {
                Console.Write("{0}", (int)(cards[i].type));
            }
            else if (cards[i].type == CardType.REVERSE)
            {
                Console.Write("R");
            }
            else if (cards[i].type == CardType.PLUS_2)
            {
                Console.Write("X");
            }
            else if (cards[i].type == CardType.PLUS_4)
            {
                Console.Write("Y");
            }
            else if (cards[i].type == CardType.WILD)
            {
                Console.Write("W");
            }
            else if (cards[i].type == CardType.SKIP)
            {
                Console.Write("S");
            }
            else
            {
                Console.Write("?");
            }
            if (i != (cards.Count - 1))
            {
                Console.Write(",");
            }
        }
    }


    static void Draw(List<Card> cards, Card cardToInsert)
    {
        bool valid = true;
        if (cardToInsert.color < CardColor.BLACK || cardToInsert.color > CardColor.YELLOW)
        {
            valid = false;
        }
        if (cardToInsert.type < CardType.ZERO || cardToInsert.type > CardType.SKIP)
        {
            valid = false;
        }
        if (valid)
        {
            cards.Add(cardToInsert);
        }
    }

    static void Play(List<Card> cards, int index)
    {
        bool valid = true;
        if (index > cards.Count || index < 0)
        {
            valid = false;
        }
        if (valid)
        {
            cards.RemoveAt(index);
        }
    }

    static void Shift(List<Card> cards, int srcIndex, int destIndex)
    {
        if (srcIndex < cards.Count && srcIndex >= 0 && destIndex < cards.Count && destIndex >= 0)
        {
            Card src = cards[srcIndex];
            Card dst = cards[destIndex];
            cards.RemoveAt(srcIndex);
            cards.Insert(srcIndex, dst);
            cards.RemoveAt(destIndex);
            cards.Insert(destIndex, src);
        }
    }

    static void DrawMany(List<Card> cards, List<Card> cardsToInsert)
    {
        foreach (Card __cards in cardsToInsert)
        {
            if (__cards.color < CardColor.BLACK || __cards.color > CardColor.YELLOW)
            {
                return;
            }
            if (__cards.type < CardType.ZERO || __cards.type > CardType.SKIP)
            {
                return;
            }
        }
        cards.AddRange(cardsToInsert);
    }
}
