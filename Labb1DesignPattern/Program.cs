using Labb1DesignPattern;
using Labb1DesignPattern.FactoryMethod;
using Labb1DesignPattern.Strategy;

//Console.WriteLine("Please choose your debit card");
//Console.WriteLine("1. Swedbank \n2. SEB \n3. Nordea");
CardContext cardContext = new CardContext();
cardContext.SetCardStrategy(new NordeaCardStrategy());
IDebitCard debitCard = cardContext.CreateCard();
Console.WriteLine(debitCard.GetBalance());
Console.WriteLine(debitCard.GetName());
cardContext.Withdraw(50);
Console.ReadLine();
