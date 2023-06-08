using UnityEngine;

public class InteractionInvoker : MonoBehaviour
{
    private InteractorListener s_InteractorListener;

    private void OnEnable()
    {
        InteractionEvents.InteractionAttempt += InteractionAttempt;
    }

    private void OnDisable()
    {
        InteractionEvents.InteractionAttempt -= InteractionAttempt;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponent<InteractorListener>()) return;
        s_InteractorListener = collision.GetComponent<InteractorListener>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<InteractorListener>() != s_InteractorListener) return;
        s_InteractorListener = null;
    }

    private void InteractionAttempt()
    {
        if (s_InteractorListener == null) return;
        s_InteractorListener.Interact();
    }
}
