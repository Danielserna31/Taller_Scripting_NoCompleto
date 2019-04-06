using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FoodProj : MonoBehaviour
{
    [SerializeField] private FoodEnum foodType;
    private Rigidbody mBody;

    private void Awake()
    {
        mBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
