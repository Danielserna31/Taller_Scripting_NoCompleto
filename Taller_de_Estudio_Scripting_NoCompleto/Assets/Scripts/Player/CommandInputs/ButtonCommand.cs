using UnityEngine;

public class ButtonCommand : MonoBehaviour
{
    #region Variables
    [SerializeField] private ButtonInput upButton;
    [SerializeField] private ButtonInput downButton;
    [SerializeField] private ButtonInput rightButton;
    [SerializeField] private ButtonInput leftButton;
    [SerializeField] private ButtonInput fireButton;
    [SerializeField] private ButtonInput changeButton;
    private Vector2 startPosition;
    private bool goUp = false, goDown = false, goLeft = false, goRight = false, shooting = false, 
        changing = false;
    #endregion

    #region Functions
    private void Start()
    {
        upButton.OnButtonDown = () => goUp = true;
        upButton.OnButtonUp = () => goUp = false;
        downButton.OnButtonDown = () => goDown = true;
        downButton.OnButtonUp = () => goDown = false;
        rightButton.OnButtonDown = () => goRight = true;
        rightButton.OnButtonUp = () => goRight = false;
        leftButton.OnButtonDown = () => goLeft = true;
        leftButton.OnButtonUp = () => goLeft = false;
        fireButton.OnButtonDown = () => shooting = true;
        fireButton.OnButtonUp = () => shooting = false;
        changeButton.OnButtonDown = () => changing = true;
    }

    public bool ExecuteMove(out float moveSenseZ, out float moveSenseX)
    {
        moveSenseZ = 0f;
        moveSenseX = 0f;
        bool isExecuting = false;
        
        return isExecuting;
    }

    public bool ExecuteShoot()
    {
        return false;
    }

    public bool ExecuteChangeProj()
    {
        return false;
    }

    public bool ExecuteRotation(out float rotSenseY)
    {
        if (Input.touchCount == 0)
            startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 newPosition = Input.GetTouch(0).position;
                Vector2 positionDifference = newPosition - startPosition;
                rotSenseY = positionDifference.x/100;
                return true;
            }
            startPosition = Input.GetTouch(0).position;
        }
        rotSenseY = 0;
        return false;
    }
    #endregion
}
