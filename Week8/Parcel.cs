namespace Week8;

public class Parcel : DeliveryItem
{
    public string Dimensions{ get; }

    public Parcel(string TrackingNumber, double Weight, string dimensions) : base(TrackingNumber, Weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        const int _fixed = 50;
        double newCost = _fixed + (Weight * 25);
        return newCost;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");
    }
}