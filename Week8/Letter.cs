namespace Week8;

public class Letter : DeliveryItem
{
    public Letter(string TrackingNumber, double Weight) : base(TrackingNumber, Weight)
    {
        
    }

    public override double CalculateCost()
    {
        const int _fixed = 15;
        double newCost = _fixed + (Weight * 10);
        return newCost;
    }
}