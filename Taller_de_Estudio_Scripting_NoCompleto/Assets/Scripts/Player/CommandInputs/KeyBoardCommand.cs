using UnityEngine;

public class KeyBoardCommand : MonoBehaviour
{
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
        rotSenseY = Input.GetAxis("Mouse X");
        if (rotSenseY != 0)
        {
            return true;
        }
        return false;
    }
}
