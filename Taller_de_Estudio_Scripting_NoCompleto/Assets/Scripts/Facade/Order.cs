
public struct Order
{
    private int meatNeeded;
    private int breadNeeded;
    private int lettuceNeeded;
    private int tomatoNeeded;
    public readonly int[] wholeOrder;

    public Order(int meatNeeded, int breadNeeded, int lettuceNeeded, int tomatoNeeded)
    {
        this.meatNeeded = meatNeeded;
        this.breadNeeded = breadNeeded;
        this.lettuceNeeded = lettuceNeeded;
        this.tomatoNeeded = tomatoNeeded;
        wholeOrder = new int[(int)FoodEnum.Tomato + 1];
        wholeOrder[(int)FoodEnum.Meat] = meatNeeded;
        wholeOrder[(int)FoodEnum.Bread] = breadNeeded;
        wholeOrder[(int)FoodEnum.Lettuce] = lettuceNeeded;
        wholeOrder[(int)FoodEnum.Tomato] = tomatoNeeded;
    }
}
