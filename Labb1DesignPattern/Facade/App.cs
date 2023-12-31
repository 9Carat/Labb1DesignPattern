﻿using Labb1DesignPattern.ObserverDesignPattern;
using Labb1DesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPattern.Facade
{
    public sealed class App
    {
        // This section implements the Facade & Singleton design patterns

        // The Client communicates directly with the Facade class(App.cs) which then handles all the 
        // subsystems such as choosing card strategy, calling the factory to create cards and adding observers

        // Double checking & thread-safe singleton design pattern makes sure that only one instance
        // of App can be instantiated
        private static App Instance = null;
        private static readonly object InstanceLock = new object();
        public static App GetInstance()
        {
            if (Instance == null)
            {
                lock (InstanceLock)
                {
                    if (Instance == null)
                    {
                        Instance = new App();
                    }
                }
            }
            return Instance;
        }
        private App() 
        {

        }
        public void Run()
        {
            // Creates a cardContext and a card strategy based on the users input
            CardContext cardContext = new CardContext();
            Console.WriteLine("Welcome to our bank. Please enter your name");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {name}!");
            int selectedCard = 0;
            do
            {
                try
                {
                    Console.WriteLine("Please choose your debit card");
                    Console.WriteLine("1. Swedbank \n2. SEB \n3. Nordea");
                    selectedCard = Convert.ToInt32(Console.ReadLine());
                    switch (selectedCard)
                    {
                        case 1:
                            cardContext.SetCardStrategy(new SwedbankCardStrategy());
                            break;
                        case 2:
                            cardContext.SetCardStrategy(new SEBCardStrategy());
                            break;
                        case 3:
                            cardContext.SetCardStrategy(new NordeaCardStrategy());
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (selectedCard < 1 || selectedCard > 3);


            // Calls the strategyContext and corresponding factory to create a new debit card depending on input from user
            IDebitCard debitCard = cardContext.CreateCard();
            Console.Clear();
            Console.WriteLine("Would you like to recieve a notification after a withdrawal from your account has been made? Reply yes/no");
            string notification = Console.ReadLine();
            IObserver observer1 = null;

            // Registers an observer if the user wants to recieve notifications
            if (notification != "no")
            {
                observer1 = new Observer(name);
                debitCard.RegisterObserver(observer1);
            }
            Console.Clear();
            Console.WriteLine($"Selected card: {debitCard.GetName()}");
            Console.WriteLine($"Balance: {debitCard.GetBalance()}");

            // Calls the corresponding strategy to execute the withdrawal
            do
            {
                try
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    cardContext.Withdraw(amount);
                    Console.ReadLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Please try again");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true);
        }
    }
}
