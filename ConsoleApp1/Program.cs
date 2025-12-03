string? name = "user";
string productname = "produckt";
double price = 22.50;
string address = "strret";
int housenomber = 25;

Console.WriteLine("Order 1. Write name: ");
name = Console.ReadLine();
Console.WriteLine("Produckt name: ");
productname = Console.ReadLine();
Console.WriteLine("Produckt price: ");
price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Address. Wrire street name: ");
address = Console.ReadLine();
Console.WriteLine("House number: ");
housenomber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Order #1");
Console.WriteLine($"Client: {name}.");
Console.WriteLine($"Product: {productname}, price {price} EUR.");
Console.WriteLine($"Address: {address} {housenomber}.");

Console.WriteLine("Order 2. Write name: ");
name = Console.ReadLine();
Console.WriteLine("Produckt name: ");
productname = Console.ReadLine();
Console.WriteLine("Produckt price: ");
price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Address. Wrire street name: ");
address = Console.ReadLine();
Console.WriteLine("House number: ");
housenomber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Order #2");
Console.WriteLine($"Client: {name}.");
Console.WriteLine($"Product: {productname}, price {price} EUR.");
Console.WriteLine($"Address: {address} {housenomber}.");

Console.WriteLine("Order 3. Write name: ");
name = Console.ReadLine();
Console.WriteLine("Produckt name: ");
productname = Console.ReadLine();
Console.WriteLine("Produckt price: ");
price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Address. Wrire street name: ");
address = Console.ReadLine();
Console.WriteLine("House number: ");
housenomber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Order #3");
Console.WriteLine($"Client: {name}.");
Console.WriteLine($"Product: {productname}, price {price} EUR.");
Console.WriteLine($"Address: {address} {housenomber}.");