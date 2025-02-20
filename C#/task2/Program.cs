using System;

class Item
{
    public string ItemCode { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Item(string itemCode, string name, double price, int stock)
    {
        ItemCode = itemCode;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Item Code: {ItemCode}, Name: {Name}, Price: {Price}, Stock: {Stock}");
    }

    public void SellItem(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} {Name}(s) sold. Remaining stock: {Stock}");
        }
        else
        {
            Console.WriteLine("Insufficient stock.");
        }
    }
}

// Derived class for Book
class Book : Item
{
    public string Author { get; set; }
    public string Edition { get; set; }
    public string Publisher { get; set; }
    public int YearOfPublication { get; set; }

    public Book(string itemCode, string name, double price, int stock, string author, string edition, string publisher, int year)
        : base(itemCode, name, price, stock)
    {
        Author = author;
        Edition = edition;
        Publisher = publisher;
        YearOfPublication = year;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Author: {Author}, Edition: {Edition}, Publisher: {Publisher}, Year: {YearOfPublication}");
    }
}

// Derived class for Electronic Item
class ElectronicItem : Item
{
    public double DiscountRate { get; set; }

    public ElectronicItem(string itemCode, string name, double price, int stock, double discountRate)
        : base(itemCode, name, price, stock)
    {
        DiscountRate = discountRate;
    }

    public double ComputeDiscount()
    {
        return Price * (DiscountRate / 100);
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Discount Rate: {DiscountRate}%, Discount Amount: {ComputeDiscount()}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Create a book object
        Book book = new Book("B001", "Bash scripting", 45.99, 10, "James Ngandu", "2nd Edition", "Mukuvi records & publishers", 2023);
        book.DisplayDetails();
        book.SellItem(2);

        // Create an electronic item object
        ElectronicItem electronicItem = new ElectronicItem("E001", "Smartphone", 599.99, 5, 10);
        electronicItem.DisplayDetails();
        electronicItem.SellItem(1);
    }
}