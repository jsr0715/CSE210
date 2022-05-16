using System;

namespace unit02_hilo
{
    class Card
    {
        public int cardValue;

        ///class for a card and prompt to draws a card
        public void getNewCard(){
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,13);
        }
    }
}