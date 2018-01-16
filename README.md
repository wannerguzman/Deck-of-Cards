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
fromat.
```
2. DeckofCards
```
This class performs the entire functionalities of the program. It finds the average color
of a certain pixel. It also finds neighbors of a pixel. It creates a queue with similarities
from the average color and neighbors. It also constructs the main disjoint set and
performs union when a similarity is found and recolors the pixels.

```
3.Main
```
Main class has the main method wich runs the main program.
I create a Deck of cards, print out the deck. Then I shuffle 
the deck of cards and re-print to the console. Then I call
the dealOndeCard 53 times and print that out, which also prints
null when all cards have been dealt with at the 53rd call of the method.
```
