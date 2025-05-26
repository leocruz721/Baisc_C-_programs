using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    // Represents a single playing card
    class Card
    {
        public string Suit { get; }
        public string Rank { get; }
        public int Value { get; }

        public Card(string rank, string suit, int value)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    // Deck class to handle cards
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    int value;
                    if (int.TryParse(rank, out value))
                    {
                        // Number cards 2-10
                    }
                    else if (rank == "Ace")
                    {
                        value = 11; // Ace starts as 11
                    }
                    else
                    {
                        value = 10; // Face cards
                    }

                    cards.Add(new Card(rank, suit, value));
                }
            }
        }

        // Shuffle the deck
        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // Deal a card from the deck
        public Card DealCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("No cards left in the deck.");

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!\n");

            Deck deck = new Deck();
            deck.Shuffle();

            List<Card> playerHand = new List<Card>();
            List<Card> dealerHand = new List<Card>();

            // Deal two cards to player and dealer
            playerHand.Add(deck.DealCard());
            playerHand.Add(deck.DealCard());

            dealerHand.Add(deck.DealCard());
            dealerHand.Add(deck.DealCard());

            bool playerBust = false;
            bool dealerBust = false;

            // Player's turn
            while (true)
            {
                Console.WriteLine("\nYour hand:");
                DisplayHand(playerHand);
                int playerScore = CalculateScore(playerHand);
                Console.WriteLine($"Your score: {playerScore}");

                Console.WriteLine("\nDealer's visible card:");
                Console.WriteLine(dealerHand[0]);

                if (playerScore > 21)
                {
                    Console.WriteLine("You busted! Dealer wins.");
                    playerBust = true;
                    break;
                }

                Console.WriteLine("\nDo you want to (H)it or (S)tand?");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "H")
                {
                    playerHand.Add(deck.DealCard());
                }
                else if (choice == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter H or S.");
                }
            }

            // Dealer's turn if player didn't bust
            if (!playerBust)
            {
                Console.WriteLine("\nDealer's turn.");
                DisplayHand(dealerHand);
                int dealerScore = CalculateScore(dealerHand);
                Console.WriteLine($"Dealer's score: {dealerScore}");

                while (dealerScore < 17)
                {
                    Console.WriteLine("Dealer hits.");
                    dealerHand.Add(deck.DealCard());
                    DisplayHand(dealerHand);
                    dealerScore = CalculateScore(dealerHand);
                    Console.WriteLine($"Dealer's score: {dealerScore}");
                }

                if (dealerScore > 21)
                {
                    Console.WriteLine("Dealer busted! You win!");
                    dealerBust = true;
                }
                else
                {
                    // Compare scores
                    int playerScore = CalculateScore(playerHand);
                    Console.WriteLine();

                    if (playerScore > dealerScore)
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (playerScore < dealerScore)
                    {
                        Console.WriteLine("Dealer wins.");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!");
                    }
                }
            }

            Console.WriteLine("\nGame over. Thanks for playing!");
            Console.ReadLine();
        }

        // Calculate the score for a hand of cards, adjusting for Aces
        static int CalculateScore(List<Card> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                score += card.Value;
                if (card.Rank == "Ace")
                    aceCount++;
            }

            // Adjust for Aces if score is over 21
            while (score > 21 && aceCount > 0)
            {
                score -= 10; // Count Ace as 1 instead of 11
                aceCount--;
            }

            return score;
        }

        // Display cards in the hand
        static void DisplayHand(List<Card> hand)
        {
            foreach (var card in hand)
            {
                Console.WriteLine(card);
            }
        }
    }
}
