using System.Collections.Generic;
using UnityEngine;

public class PoolFactory : MonoBehaviour
{
    public static PoolFactory PoolData;
    private Dictionary<FoodEnum, GameObjectPool> gameObjectPoolsDict;

    private void Awake()
    {
        if (PoolData == null)
            PoolData = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        gameObjectPoolsDict = new Dictionary<FoodEnum, GameObjectPool>();
        GameObjectPool newPool1 = gameObject.AddComponent<GameObjectPool>();
        newPool1.PoolGameObject = Resources.Load<GameObject>("Prefabs/Meat");
        gameObjectPoolsDict.Add(FoodEnum.Meat, newPool1);
        GameObjectPool newPool2 = gameObject.AddComponent<GameObjectPool>();
        newPool2.PoolGameObject = Resources.Load<GameObject>("Prefabs/Bread");
        gameObjectPoolsDict.Add(FoodEnum.Bread, newPool2);
        GameObjectPool newPool3 = gameObject.AddComponent<GameObjectPool>();
        newPool3.PoolGameObject = Resources.Load<GameObject>("Prefabs/Lettuce");
        gameObjectPoolsDict.Add(FoodEnum.Lettuce, newPool3);
        GameObjectPool newPool4 = gameObject.AddComponent<GameObjectPool>();
        newPool4.PoolGameObject = Resources.Load<GameObject>("Prefabs/Tomato");
        gameObjectPoolsDict.Add(FoodEnum.Tomato, newPool4);
    }

    public GameObject GetGameObjectPool(FoodEnum tKey)
    {
        return null;
    }

    public void ReturnGameObjectToPools(GameObject objToReturn, FoodEnum tKey)
    {
    }
}
