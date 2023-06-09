using UnityEngine.Events;

public static class FadeEvents
{
    public static event UnityAction FadeIn;
    public static void InvokeFadeIn()
    {
        FadeIn?.Invoke();
    }

    public static event UnityAction FadeOut;
    public static void InvokeFadeOut()
    {
        FadeOut?.Invoke();
    }
}
