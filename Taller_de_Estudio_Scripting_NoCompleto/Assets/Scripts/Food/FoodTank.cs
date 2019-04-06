using UnityEngine;

public class FoodTank : MonoBehaviour
{
    [SerializeField] private FoodEnum recievableFood;

    public FoodEnum RecievableFood { get => recievableFood; private set => recievableFood = value; }

    public void StorageResource()
    {
    }
}
