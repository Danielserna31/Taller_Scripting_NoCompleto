using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    #region Delegates
    public delegate void ButtonHandler();
    public ButtonHandler OnButtonDown;
    public ButtonHandler OnButtonUp;
    #endregion

    #region Variables
    private Button button;
    public bool buttonPressed { get; set; } = false;
    #endregion

    #region Functions
    void Start()
    {
        button = GetComponent<Button>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnButtonDown?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnButtonUp?.Invoke();
    }
    #endregion
}
