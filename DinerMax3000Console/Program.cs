// See https://aka.ms/new-console-template for more information
using DinerMax3000Console;

FoodMenu summerMenu = new FoodMenu();
summerMenu.Name = "Summer Menu";
summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Slamon with Sandefjord butter.", 25.50);
summerMenu.AddMenuItem("Taco", "All people eat Tacos on Tuesdays.", 10);
summerMenu.AddMenuItem("BBQ", "Who doesn't love BBQ.", 12);
summerMenu.HospitalDirections = "Right around the corner, two block to the left.";

DrinkMenu outsideDrinks = new DrinkMenu();
outsideDrinks.Disclaimer = "Do not drink and code.";
outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A classic", 10);
outsideDrinks.AddMenuItem("Screwdriver", "Makes you hammared", 15);

Order hungryGuestOrder = new Order();
for (int x=0; x<=summerMenu.items.Count-1; x++)
{
    MenuItem currentItem = summerMenu.items[x];
    hungryGuestOrder.items.Add(currentItem);
}

foreach(MenuItem currentItem in outsideDrinks.items)
{
    hungryGuestOrder.items.Add(currentItem);
}

Console.WriteLine("The total is: " + hungryGuestOrder.Total);

try
{
    outsideDrinks.AddMenuItem("Himkok", "9 out of 10 people reccomend staying away from thsi drink", -10);

} 
catch(Exception thrownException)
{
    Console.WriteLine(thrownException.Message);
}

