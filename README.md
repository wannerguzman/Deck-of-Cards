# Deck of Cards Program in c#
#### To go directly to the folder that contains the files and source Code, press the following link below:
[Source Code](/DeckofCards/DeckofCards/)

### The program has a Deck 52 cards with:
- 4 suits: hearts​, spades​, clubs​, diamonds
- Face values of: Ace​, 2-10​, Jack​, Queen​, and King​).
### In the DeckofCard class I have provided the following operations:
- shuffle() - Shuffle the cards by swapping random cards and returns nothing.
- dealOneCard() - returns one card from the deck to the caller. Before this method
is called we first shuffle and then perform 52 calls to this method. If a 53 call is
performed it will return null because all 52 cards have already been dealt with.

## Table of Contents
1. [Classes](#classes)
2. [Compile](#compile)
4. [Example Run](#example-run)

# Classes
1. Card
[Source Code](/DeckofCards/DeckofCards/Card.cs)
```
Create an object Card. A card has a face and a suit. I also write a method to represent the card in a toSting
format.
```
2. DeckofCards
[Source Code](/DeckofCards/DeckofCards/DeckofCards.cs)

```
In the deck of cards I create all possible 52 cards in the constructor. I store the cards in an array. I also
have a variable that stores the index of the next card to be returned by dealOneCard method which I also 
provided. If the next index is outside of the array we have means all cards already dealt. I also provide the 
shuffle method. I randomly shuffle by swapping the card in each index of the deck by another random card. I also 
have a method thatdisplays the deck when called.
```
3.Main
[Source Code](/DeckofCards/DeckofCards/Main.cs)

```
Main class has the main method which runs the main program. I create a Deck of cards, print out the deck. Then I 
shuffle the deck of cards and re-print to the console. Then I call the dealOndeCard 53 times and print that out, 
which also prints null when all cards have been dealt with at the 53rd call of the method.
```
# Compile
```
The way I approached this assignment was by first downloading Visual Studio and making sure the I also
installed the packages to run a C# application. This was the first time I built and ran a c# application
but was easy since it is familiar to java. I also wanted to try something new. I created a new c# project
in Visual Studio and create a file Main with the Main class and main method and another file card with the
Card class and lastly a DeckofCard file that contained the DeckofCard class. All files were in the namespace
of DeckofCards. First, I wrote it as if I was writing a java program but modified it to c#. Then made sure there
were no errors it ran perfectly. I make it print out to the console, demonstrating the required specifications.
To view what was printed out to the console I performed start without debugging and there you will be able to see
that first I print the deck and then shuffle and re-print and lastly print after each dealOneCard call.

```
# Example Run
## Console Window
```
-----------------------Deck before shuffling-----------------------------
2 of Diamonds
3 of Diamonds
4 of Diamonds
5 of Diamonds
6 of Diamonds
7 of Diamonds
8 of Diamonds
9 of Diamonds
10 of Diamonds
Jack of Diamonds
Queen of Diamonds
king of Diamonds
Ace of Diamonds
2 of Clubs
3 of Clubs
4 of Clubs
5 of Clubs
6 of Clubs
7 of Clubs
8 of Clubs
9 of Clubs
10 of Clubs
Jack of Clubs
Queen of Clubs
king of Clubs
Ace of Clubs
2 of Hearts
3 of Hearts
4 of Hearts
5 of Hearts
6 of Hearts
7 of Hearts
8 of Hearts
9 of Hearts
10 of Hearts
Jack of Hearts
Queen of Hearts
king of Hearts
Ace of Hearts
2 of Spades
3 of Spades
4 of Spades
5 of Spades
6 of Spades
7 of Spades
8 of Spades
9 of Spades
10 of Spades
Jack of Spades
Queen of Spades
king of Spades
Ace of Spades
-----------------------Deck After Shuffling------------------------------
6 of Hearts
2 of Spades
9 of Hearts
Jack of Hearts
king of Clubs
5 of Diamonds
9 of Spades
8 of Clubs
4 of Clubs
Queen of Diamonds
Ace of Diamonds
Queen of Hearts
10 of Hearts
Jack of Spades
7 of Clubs
8 of Diamonds
king of Diamonds
2 of Clubs
5 of Spades
Queen of Spades
4 of Diamonds
king of Spades
Jack of Diamonds
3 of Diamonds
8 of Spades
3 of Spades
10 of Diamonds
5 of Hearts
Jack of Clubs
3 of Clubs
8 of Hearts
10 of Clubs
Ace of Hearts
7 of Spades
king of Hearts
7 of Hearts
4 of Hearts
6 of Spades
Queen of Clubs
Ace of Clubs
10 of Spades
Ace of Spades
5 of Clubs
9 of Clubs
9 of Diamonds
7 of Diamonds
6 of Clubs
6 of Diamonds
2 of Hearts
2 of Diamonds
4 of Spades
3 of Hearts
-----------------------53 calls to dealOndeCard()------------------------
6 of Hearts
2 of Spades
9 of Hearts
Jack of Hearts
king of Clubs
5 of Diamonds
9 of Spades
8 of Clubs
4 of Clubs
Queen of Diamonds
Ace of Diamonds
Queen of Hearts
10 of Hearts
Jack of Spades
7 of Clubs
8 of Diamonds
king of Diamonds
2 of Clubs
5 of Spades
Queen of Spades
4 of Diamonds
king of Spades
Jack of Diamonds
3 of Diamonds
8 of Spades
3 of Spades
10 of Diamonds
5 of Hearts
Jack of Clubs
3 of Clubs
8 of Hearts
10 of Clubs
Ace of Hearts
7 of Spades
king of Hearts
7 of Hearts
4 of Hearts
6 of Spades
Queen of Clubs
Ace of Clubs
10 of Spades
Ace of Spades
5 of Clubs
9 of Clubs
9 of Diamonds
7 of Diamonds
6 of Clubs
6 of Diamonds
2 of Hearts
2 of Diamonds
4 of Spades
3 of Hearts
null
Press any key to continue . . .

```
