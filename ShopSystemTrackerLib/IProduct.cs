namespace ShopSystemTrackerLib
{
    public interface IProduct
    {
        string Name { get; }
        string Description { get; }
        double Price { get; }
        int Quantity { get; }
        string Category { get; }

    }
}