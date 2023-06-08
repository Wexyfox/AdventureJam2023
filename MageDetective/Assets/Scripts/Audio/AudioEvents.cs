using UnityEngine.Events;

public static class AudioEvents
{
    public static event UnityAction<string> AmbienceChange;
    public static void InvokeAmbienceChange(string pa_AmbienceTrackName)
    {
        AmbienceChange?.Invoke(pa_AmbienceTrackName);
    }

    public static event UnityAction<string> MusicChange;
    public static void InvokeMusicChange(string pa_MusicTrackName)
    {
        MusicChange?.Invoke(pa_MusicTrackName);
    }

    public static event UnityAction<string> SfxTrigger;
    public static void InvokeSfxTrigger(string pa_SfxName)
    {
        SfxTrigger?.Invoke(pa_SfxName);
    }
}
