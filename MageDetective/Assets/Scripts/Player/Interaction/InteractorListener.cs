using UnityEngine;
using UnityEngine.Events;

public class InteractorListener : MonoBehaviour
{
    public UnityEvent InteractedWith;

    public void Interact()
    {
        InteractedWith.Invoke();
    }
}
