using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Button switchCommandControls;
    private Player mPlayer;
    #endregion

    #region Functions
    private void Awake()
    {
        mPlayer = GetComponent<Player>();
    }

    void Start()
    {
        switchCommandControls.onClick.AddListener(()=>SwitchCommand());
    }

    void Update()
    {
        
    }

    private void SwitchCommand()
    {
        print("Cambio de Command");
    }
    #endregion
}
