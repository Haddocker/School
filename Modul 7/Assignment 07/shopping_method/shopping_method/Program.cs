using shopping_method;

Item cheese = new();
cheese.Name = "Ost";
cheese.Price = 55.95;

Item milk = new();
milk.Name = "Milk";
milk.Price = 9.95;

Item flour = new();
flour.Name = "Flour";
flour.Price = 12.55;

Item[] shoppingList = {cheese, milk, flour};

CashRegister regsiter = new();
regsiter.PrintReceipt(shoppingList);

