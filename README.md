# Deck of Cards Program in c#
```
The program has a Deck 52 cards with:
● 4 suits: hearts​, spades​, clubs​, diamonds
● Face values of: Ace​, 2-10​, Jack​, Queen​, and King​).
In the DeckofCard class I have provided the following operations:
shuffle() - Shuffle the cards by swapping random cards and returns nothing.
dealOneCard() - returns one card from the deck to the caller. Before this method
is called we first shuffle and then perform 52 calls to this method. If a 53 call is
performed it will return null because all 52 cards have already been dealt with.
```
# Classes
1. Card
```
Create an object Card. A card has a face and a suit.
I also write a method to represent the card in a toSting
format.
```
2. DeckofCards
```
In the deck of cards I create all possible 52 cards in the constructor. I store the cards
in an array. I also have a variable that stores the index of the next card to be returned 
by dealOneCard method which I also provided. If the next index is outside of the array we 
have means all cards already dealt. I also provide the shuffle method. I randomly shuffle by
swapping the card in each index of the deck by another random card. I also have a method that
displays the deck when called.

```
3.Main
```
Main class has the main method which runs the main program.
I create a Deck of cards, print out the deck. Then I shuffle 
the deck of cards and re-print to the console. Then I call
the dealOndeCard 53 times and print that out, which also prints
null when all cards have been dealt with at the 53rd call of the method.

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

```
# Example Run
