using UnityEngine.Events;

public static class InteractionEvents
{
    public static event UnityAction InteractionAttempt;
    public static void InvokeInteractionAttempt()
    {
        InteractionAttempt?.Invoke();
    }
}
