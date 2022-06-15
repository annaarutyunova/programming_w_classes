using BYUI.InheritanceExamples;

Customer John = new Customer("John Smith");
Customer Anna = new Customer("Anna Arutyunova");
Anna.Purchase(25.99);
Anna.GetInfo();
John.Purchase(50.00);
John.GetInfo();
Console.WriteLine(John.Name);



Dealer Ace = new Dealer("Ace Hardware", 1234566, 0.05);
Ace.Purchase(50.00);
Ace.GetInfo();
Console.WriteLine(Ace.Name);
Console.WriteLine(Ace.DealerId);
Console.WriteLine(Ace.Discount);
