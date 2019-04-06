using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ClientObj : MonoBehaviour
{
    #region Variables
    private Client mClientInfo;
    private float waitingTime;
    [SerializeField] private Text waitingTimeText;
    [SerializeField] private Text meatNeeded;
    [SerializeField] private Text breadNeeded;
    [SerializeField] private Text lettuceNeeded;
    [SerializeField] private Text tomatoNeeded;
    public int Seat { get; set; }
    #endregion

    #region Functions
    void Start()
    {
        waitingTime = mClientInfo.patienceTime;
        meatNeeded.text = "Meat: " + mClientInfo.order.wholeOrder[(int)FoodEnum.Meat].ToString();
        breadNeeded.text = "Bread: " + mClientInfo.order.wholeOrder[(int)FoodEnum.Bread].ToString();
        lettuceNeeded.text = "Lettuce: " + mClientInfo.order.wholeOrder[(int)FoodEnum.Lettuce].ToString();
        tomatoNeeded.text = "Tomato: " + mClientInfo.order.wholeOrder[(int)FoodEnum.Tomato].ToString();
        StartCoroutine(WalkOut());
    }

    public void TryToSatisfyClient()
    {
        print("Trying to satisfy");
    }

    private IEnumerator WalkOut()
    {
        while (waitingTime > 0)
        {
            waitingTime -= Time.deltaTime;
            waitingTimeText.text = "Time: " + waitingTime.ToString("00");
            yield return null;
        }
        ClientSpawner.Instance.SeatOcuppied[Seat] = false;
        Destroy(gameObject);
    }
    #endregion
}
