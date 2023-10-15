using DZ_13;
using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

CreditCard myCard=new CreditCard("1234567890123456", "Вася Курочін", new DateTime(2025, 12, 31), 1234, 500.0);

myCard.AccountReplenished += amount => Console.WriteLine($"Рахунок поповнено на {amount:C}");
myCard.FundsSpent += amount => Console.WriteLine($"Витрачені кошти: {amount:C}");
myCard.CreditUsageStarted += () => Console.WriteLine("Кредит почався");
myCard.CreditLimitReached+=() => Console.WriteLine($"Кредитний ліміт досягнуто");
myCard.PinChanged += newPin => Console.WriteLine($"PIN-код змінено на {newPin}");

myCard.ReplenishAccount(200.0);
myCard.Display();

myCard.SpendMoney(100);
myCard.Display();

SaveToFile saver = new SaveToFile(myCard);
saver.Save("creditcard.txt");

myCard.ChangePin(4545);

myCard.SpendMoney(300);
myCard.Display();

myCard.SpendMoney(300);
myCard.Display();

saver.Read("creditcard.txt");

