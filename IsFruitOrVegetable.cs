namespace TestApp
{
    public enum FoodType
    {
        None,
        Vegetable,
        Fruit
    }
    public interface IsFruitOrVegetable
    {
        FoodType Type { get; set; }
        string Name { get; set; }
    }
}
