using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerClientOrderCompletion : MonoBehaviour
{
    private ClientObj clientObj;

    private void Awake()
    {
        clientObj = GetComponentInParent<ClientObj>();
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}
