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
        }

    }


    static void Draw(List<Card> cards, Card cardToInsert)
    {

    }

    static void Play(List<Card> cards, int index)
    {

    }

    static void Shift(List<Card> cards, int srcIndex, int destIndex)
    {

    }


}
