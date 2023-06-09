using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private string e_MusicTrack;
    [SerializeField] private string e_AmbienceTrack;

    private void Start()
    {
        AudioEvents.InvokeMusicChange(e_MusicTrack);
        AudioEvents.InvokeAmbienceChange(e_AmbienceTrack);
        FadeEvents.InvokeFadeIn();
    }
}
