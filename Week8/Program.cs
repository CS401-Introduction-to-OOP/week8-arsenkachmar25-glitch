namespace Week8;

class Program
{
    static void Main()
    {
        Letter letter1 = new Letter("LT-0001", 0.3);
        Letter letter2 = new Letter("LT-0002", 0.7);
        Parcel parcel1 = new Parcel("PC-0001", 2.5, "10x15x5 cm");
        Parcel parcel2 = new Parcel("PC-0002", 5.0, "20x20x20 cm");

        Console.WriteLine("Polymorphism:");
        
        letter1.PrintInfo();
        parcel1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new();

        Console.WriteLine("Adding Items to ur cargo:");
        
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        
        double totalCost = myCargo.GetTotalCost();
        Console.WriteLine($"Total Delivery Cost: {totalCost}");
        
    }
}