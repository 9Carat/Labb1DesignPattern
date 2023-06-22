using Labb1DesignPattern.Facade;

// The following application implements the Factory method, Singleton, Strategy, Observer and Facade design patterns
// The client calls the Facade class(App.cs)
var app = App.GetInstance();
app.Run();
