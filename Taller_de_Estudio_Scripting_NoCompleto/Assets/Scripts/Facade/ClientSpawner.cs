using UnityEngine;

public class ClientSpawner : MonoBehaviour
{
    #region Variables
    public static ClientSpawner Instance { get; private set; }
    [SerializeField] private Vector2 timeIntervalBetweenSpawns;
    [SerializeField] private Vector3[] seats;
    private ClientObj client;
    private float timeForSpawn, timeCounter;
    public bool[] SeatOcuppied { get; set; }
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
        SeatOcuppied = new bool[seats.Length];
        client = Resources.Load<ClientObj>("Prefabs/Client");
        timeForSpawn = Random.Range(timeIntervalBetweenSpawns.x, timeIntervalBetweenSpawns.y);
    }

    private void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter >= timeForSpawn)
        {
            timeCounter = 0;
            timeForSpawn = Random.Range(timeIntervalBetweenSpawns.x, timeIntervalBetweenSpawns.y);
            TrySpawningClient();
        }
    }

    public void TrySpawningClient()
    {
        for (int i = 0; i<SeatOcuppied.Length; i++)
        {
            if (!SeatOcuppied[i])
            {
                SeatOcuppied[i] = true;
                ClientObj newClientObj = Instantiate(client, seats[i], Quaternion.identity);
                newClientObj.Seat = i;
                break;
            }
        }
    }
    #endregion
}
