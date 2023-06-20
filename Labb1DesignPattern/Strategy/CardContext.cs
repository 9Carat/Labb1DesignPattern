﻿using Labb1DesignPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.Strategy
{
    internal class CardContext
    {
        private ICardStrategy _cardStrategy;
        public void SetCardStrategy(ICardStrategy cardStrategy)
        {
            _cardStrategy = cardStrategy;
        }
        public void Withdraw(double amount)
        {
            _cardStrategy.Withdraw(amount);
        }
        public IDebitCard CreateCard() 
        {
            IDebitCard card = _cardStrategy.CreateCard();
            return card;
        }
    }
}