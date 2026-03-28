namespace Week8;

class Program
{
    static void Main()
    {
        Letter myLetter = new Letter("LT-123456", 0.5);
        Parcel myParcel = new Parcel("PC-987654", 2.5, "10x10x5 cm");
        
        List<DeliveryItem> deliveries = new List<DeliveryItem>
        {
            myLetter,
            myParcel
        };
        
        Console.WriteLine("Delivery Items");
        
        foreach (DeliveryItem item in deliveries)
        {
            Console.WriteLine(); 
            
            item.PrintInfo(); 

            double cost = item.CalculateCost();
            Console.WriteLine($"Shipping Cost : ${cost}");
        }
        
    }
}