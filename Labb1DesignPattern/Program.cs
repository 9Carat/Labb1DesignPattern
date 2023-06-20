using Labb1DesignPattern;
using Labb1DesignPattern.FactoryMethod;
using Labb1DesignPattern.ObserverDesignPattern;
using Labb1DesignPattern.Strategy;
using System;

CardContext cardContext = new CardContext();
Console.WriteLine("Welcome to our bank. Please enter your name");
string name = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Hello {name}!");
Console.WriteLine("Please choose your debit card");
Console.WriteLine("1. Swedbank \n2. SEB \n3. Nordea");
int selectedCard = Convert.ToInt32(Console.ReadLine());
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
        Console.WriteLine("Invalid option");
        break;
}
IDebitCard debitCard = cardContext.CreateCard();
Console.Clear();
Console.WriteLine("Would you like to recieve a notification after a withdrawal from your account has been made? Reply yes/no");
string notification = Console.ReadLine();
IObserver observer1 = null;
if (notification != "no")
{
    observer1 = new Observer(name);
    debitCard.RegisterObserver(observer1);
}
Console.Clear();
Console.WriteLine($"Selected card: {debitCard.GetName()}");
Console.WriteLine($"Balance: {debitCard.GetBalance()}");
Console.WriteLine("How much would you like to withdraw?");
double amount = Convert.ToDouble(Console.ReadLine());
cardContext.Withdraw(amount);
Console.ReadLine();
