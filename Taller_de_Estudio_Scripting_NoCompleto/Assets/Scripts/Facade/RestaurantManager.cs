using UnityEngine;

public class RestaurantManager 
{
    #region Singleton Instance
    private static RestaurantManager restaurant = null;
    public static RestaurantManager Restaurant
    {
        get
        {
            if (restaurant == null)
            {
                restaurant = new RestaurantManager(500);
            }
            return restaurant;
        }
    }
    #endregion

    #region Variables
    public float Money { get; private set; }
    public int[] CollectedIngredients { get; private set; }
    private Client[] possibleClients;
    #endregion

    #region Functions
    public RestaurantManager(float money)
    {
        Money = money;
        CollectedIngredients = new int[4];
        possibleClients = new Client[]
        {
            new Client(new Order(2, 3, 5, 4), 35, 200),
            new Client(new Order(5, 6, 2, 3), 35, 250),
            new Client(new Order(1, 2, 9, 6), 45, 300)
        };
    }
    #endregion
}
