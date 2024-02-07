using System;
using System.Globalization;

class RoseBlanches
{
    static void Main()
    {

        const int COFFEE_PRICE = 2;
        const int FLASH_COMPUTER_PRICE = 4;
        const int SUBWAY_TICKET_PRICE = 3;

        Console.Write("How much money did you receive ($)? ");
        decimal money = decimal.Parse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

        decimal booksAndSupplies = money * 3 / 4;
        Console.WriteLine("Books and Supplies: {0} $", booksAndSupplies);

        decimal remaining = money - booksAndSupplies;

        int coffees = (int)(remaining / COFFEE_PRICE);
        coffees = Math.Min(coffees, 33); 
        remaining -= coffees * COFFEE_PRICE;

        int flashComputers = (int)(remaining / FLASH_COMPUTER_PRICE);
        flashComputers = Math.Min(flashComputers, 16); 
        remaining -= flashComputers * FLASH_COMPUTER_PRICE;

        int subwayTickets = (int)(remaining / SUBWAY_TICKET_PRICE);
        subwayTickets = Math.Min(subwayTickets, 22); 
        remaining -= subwayTickets * SUBWAY_TICKET_PRICE;

        Console.WriteLine("You can then buy:");
        Console.WriteLine("{0} coffees", coffees);
        Console.WriteLine("{0} Flash Computer Numbers", flashComputers);
        Console.WriteLine("{0} subway tickets", subwayTickets);
        Console.WriteLine("and you will have {0} dollars for the white roses.", remaining);

        Console.ReadLine();
    }
}
