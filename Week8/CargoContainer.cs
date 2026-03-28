namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
        Console.WriteLine($"Item {item.TrackingNumber} has been added");
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (T item in _items)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}