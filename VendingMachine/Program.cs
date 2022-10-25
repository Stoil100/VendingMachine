using System;
class Program
{
    public static Customer customer = new Customer(100);
    public static bool start = true;

    static void Main(string[] args)
    {

        Console.WriteLine("Press 'b' for Beverages  'i' to view inventory 'r' to refill. Any other key to quit: ");
        char itemType = Console.ReadKey().KeyChar;
        Console.WriteLine();

        while (itemType != 'q')
        {

            switch (itemType)
            {
                case 'b':
                    Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back <--.");
                    foreach (Beverage beverages in Beverage.beverageMenu)
                    {
                        Console.WriteLine($"{beverages.ID}: {beverages.Name} ({beverages.Price:c}) {beverages.Count}");
                    }
                    char customerItem = Console.ReadKey().KeyChar;

                    switch (customerItem)
                    {
                        case '1':
                            if (Beverage.CocaCola.Count != 0 && customer.Money - (uint)Beverage.CocaCola.Price >= 0)
                            {
                                customer.customerInventoryList.Add(Beverage.CocaCola);

                                customer.Money -= Beverage.CocaCola.Price;
                                Beverage.CocaCola.Count -= 1;
                                Console.WriteLine($"\nYou bought a {Beverage.CocaCola.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"\nYou don't have enough money or the machine is out of this beverage");
                            }
                            break;

                        case '2':
                            if (Beverage.PepsiMax.Count != 0 && customer.Money - Beverage.PepsiMax.Price >= 0)
                            {
                                customer.customerInventoryList.Add(Beverage.PepsiMax);
                                customer.Money -= Beverage.PepsiMax.Price;
                                Beverage.PepsiMax.Count -= 1;
                                Console.WriteLine($"\nYou bought a {Beverage.PepsiMax.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"\nYou don't have enough money or the machine is out of this beverage");
                            }
                            break;
                        case '3':
                            if (Beverage.Fanta.Count != 0 && customer.Money - Beverage.Fanta.Price >= 0)
                            {
                                customer.customerInventoryList.Add(Beverage.Fanta);
                                customer.Money -= Beverage.Fanta.Price;
                                Beverage.Fanta.Count -= 1;
                                Console.WriteLine($"\nYou bought a {Beverage.Fanta.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"\nYou don't have enough money or the machine is out of this beverage");
                            }
                            break;
                        case '4':
                            if (Beverage.Sprite.Count != 0 && customer.Money - Beverage.Sprite.Price >= 0)
                            {
                                customer.customerInventoryList.Add(Beverage.Sprite);
                                customer.Money -= Beverage.Sprite.Price;
                                Beverage.Sprite.Count -= 1;
                                Console.WriteLine($"\nYou bought a {Beverage.Sprite.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"\nYou don't have enough money or the machine is out of this beverage");
                            }
                            break;
                    }
                    break;

                case 'i':
                    Console.WriteLine($"\nCustomer money: {customer.Money:c}.");
                    Console.WriteLine($"Customer inventory:");
                    foreach (VendingMachine customerItemInventory in customer.customerInventoryList)
                    {
                        Console.WriteLine(customerItemInventory.Name);
                    }
                    break;
                case 'r':
                    Console.WriteLine("\nInsert the amount you want");
                    try
                    {
                        customer.Money += int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("\nInvalid input try again");
                    }
                    break;

                default:
                    return;
            }
            Console.WriteLine("\n\nPress 'b' for Beverages and 'i' to view inventory 'r' to refill. Any other key to quit: ");
            itemType = Console.ReadKey().KeyChar;
        }
    }
}
