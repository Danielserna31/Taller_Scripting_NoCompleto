using UnityEngine;
using UnityEngine.UI;

public class UiResources : MonoBehaviour
{
    #region Variables
    public static UiResources Instance { get; set; }
    [SerializeField] private Text moneyText;
    [SerializeField] private Text meatText;
    [SerializeField] private Text breadText;
    [SerializeField] private Text lettuceText;
    [SerializeField] private Text tomatoText;
    #endregion

    #region Functions
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        UpdateUi();
    }

    public void UpdateUi()
    {
        print("hey");
        moneyText.text = "Money: " + RestaurantManager.Restaurant.Money.ToString("00.00");
        meatText.text = "Meat: " + RestaurantManager.Restaurant.CollectedIngredients[(int)FoodEnum.Meat].ToString();
        breadText.text = "Bread: " + RestaurantManager.Restaurant.CollectedIngredients[(int)FoodEnum.Bread].ToString();
        lettuceText.text = "Lettuce: " + RestaurantManager.Restaurant.CollectedIngredients[(int)FoodEnum.Lettuce].ToString();
        tomatoText.text = "Tomato: " + RestaurantManager.Restaurant.CollectedIngredients[(int)FoodEnum.Tomato].ToString();
    }
    #endregion
}
