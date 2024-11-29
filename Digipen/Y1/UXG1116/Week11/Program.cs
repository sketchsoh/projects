using System;
using System.Collections.Generic;

partial class Program
{
    static Card MakeCard(int color, int type)
    {
        Card card = new Card();
        card.color = (CardColor)color;
        card.type = (CardType)type;
        return card;
    }
    
    static void TestPrint(List<Card> cards) {
       Console.Write("deck -> [");
       PrintDeck(cards);
       Console.Write("]");
       Console.WriteLine();
    }
    
    static void TestDraw(List<Card> cards, Card cardToInsert) {
        Console.Write("original deck -> [");
        PrintDeck(cards);
        Console.WriteLine("]");
        
        Console.WriteLine("Inserting color = {0}, type = {1}", cardToInsert.color, cardToInsert.type);
        Draw(cards, cardToInsert);
        
        Console.Write("new deck -> [");
        PrintDeck(cards);
        Console.Write("]");
        Console.WriteLine();
        Console.WriteLine();
    }
    
    static void TestPlay(List<Card> cards, int index) {
        Console.Write("original deck -> [");
        PrintDeck(cards);
        Console.WriteLine("]");
        
        Console.WriteLine("Playing index = {0}", index);
        Play(cards, index);
        
        Console.Write("new deck -> [");
        PrintDeck(cards);
        Console.Write("]");
        Console.WriteLine();
        Console.WriteLine();
    }
   
    static void TestShift(List<Card> cards, int srcIndex, int destIndex) {
        Console.Write("original deck -> [");
        PrintDeck(cards);
        Console.WriteLine("]");
        
        Console.WriteLine("Playing swapping index {0} with {1}", srcIndex, destIndex);
        Shift(cards, srcIndex, destIndex);
        
        Console.Write("new deck -> [");
        PrintDeck(cards);
        Console.Write("]");
        Console.WriteLine();
        Console.WriteLine();
    }
   
    static void TestDrawMany(List<Card> cards, List<Card> cardsToInsert) {
        Console.Write("original deck -> [");
        PrintDeck(cards);
        Console.WriteLine("]");

        
        Console.Write("cards to draw -> [");
        PrintDeck(cardsToInsert);
        Console.Write("]");
        
        DrawMany(cards, cardsToInsert);
                
        Console.WriteLine();
        
        Console.Write("new deck -> [");
        PrintDeck(cards);
        Console.Write("]");
        Console.WriteLine();
        Console.WriteLine();
    }
   
   
	static void Main(string[] args)
	{
        {
            Console.WriteLine("=== Testing PrintDeck ===");
            
            // Normal Test
		    TestPrint(new List<Card>(){
                        MakeCard(0,0),
                        MakeCard(1,1),
                        MakeCard(2,2),
                        MakeCard(3,3),
                        MakeCard(4,4),
                        MakeCard(0,5),
                        MakeCard(1,6),
                        MakeCard(2,7),
                        MakeCard(3,8),
                        MakeCard(4,9),
                        MakeCard(0,10),
                        MakeCard(1,11),
                        MakeCard(2,12),
                        MakeCard(3,13),
                        MakeCard(4,14)});
                        
            // Lists are correct but there are invalid numbers
            TestPrint(new List<Card>(){
                        MakeCard(-1,-1),
                        MakeCard(0,0),
                        MakeCard(1,1),
                        MakeCard(2,2),
                        MakeCard(3,3),
                        MakeCard(4,4),
                        MakeCard(5,5),
                        MakeCard(6,6),
                        MakeCard(0,7),
                        MakeCard(1,8),
                        MakeCard(2,9),
                        MakeCard(3,10),
                        MakeCard(4,11),
                        MakeCard(5,12),
                        MakeCard(6,13),
                        MakeCard(-1,14),
                        MakeCard(0,15),
                        MakeCard(2,16),
                     });
                        
		}
        {
            Console.WriteLine("=== Testing Draw ===");
            List<Card> cards = new List<Card>(){
                MakeCard(1,5),
                MakeCard(2,7),
                MakeCard(4,2),
                MakeCard(3,10),
                MakeCard(0,11)
            };
            
            TestDraw(cards, MakeCard(2, 14)); // valid
            TestDraw(cards, MakeCard(0, 13)); // valid
            TestDraw(cards, MakeCard(3, 9));  // valid
            TestDraw(cards, MakeCard(1, 15));  // invalid
            TestDraw(cards, MakeCard(5, 10));  // invalid
		}
		{
            Console.WriteLine("=== Testing Play ===");
            List<Card> cards = new List<Card>(){
                MakeCard(1,5),
                MakeCard(2,7),
                MakeCard(4,2),
                MakeCard(3,10),
                MakeCard(0,11)
            };
            TestPlay(cards, 2); // valid
            TestPlay(cards, 0); // valid
            TestPlay(cards, 2);  // valid
            TestPlay(cards, 5);  // invalid
            TestPlay(cards, -1);  // invalid
		} 
        {
            Console.WriteLine("=== Testing Shift ===");
            List<Card> cards = new List<Card>(){
                MakeCard(1,5),
                MakeCard(2,7),
                MakeCard(4,2),
                MakeCard(3,10),
                MakeCard(0,11)
            };
            TestShift(cards, 0, 1); // valid
            TestShift(cards, 4, 0); // valid
            TestShift(cards, 3, 2);  // valid
            TestShift(cards, 5, 2);  // invalid
            TestShift(cards, 2, 5);  // invalid
		} 
        {
            Console.WriteLine("=== Testing DrawMany ===");
            List<Card> cards = new List<Card>(){
                MakeCard(1,5),
                MakeCard(2,7),
                MakeCard(4,2),
                MakeCard(3,10),
                MakeCard(0,11)
            };
            
            TestDrawMany(cards, 
                         new List<Card>() { MakeCard(0,1) }); // valid; one element
                         
            TestDrawMany(cards,
                         new List<Card>(){ 
                            MakeCard(3,4),
                            MakeCard(10,12)
                         }); // valid; two elements
                         
            TestDrawMany(cards,
                         new List<Card>(){ 
                            MakeCard(1,12),
                            MakeCard(1,12),
                            MakeCard(1,12),
                         }); // valid; three elements
                         
                        
            TestDrawMany(cards, 
                         new List<Card>(){ 
                            MakeCard(1,12),
                            MakeCard(2,12),
                            MakeCard(5,12),
                         });// invalid; bad elements in colors
                         
            TestDrawMany(cards, 
                         new List<Card>(){ 
                            MakeCard(1,12),
                            MakeCard(2,16),
                            MakeCard(3,12),
                         });  // invalid; bad elements in type
		}
		
    }
	
	
}
