using UnityEngine;

public class AudioEventListener : MonoBehaviour
{
    [SerializeField] private MusicSO so_Music;
    [SerializeField] private AmbienceSO so_Ambience;
    [SerializeField] private SfxSO so_Sfx;

    [SerializeField] private AudioSource pr_MusicSource;
    [SerializeField] private AudioSource pr_AmbienceSource;
    [SerializeField] private AudioSource[] pr_SfxSources;

    private void OnEnable()
    {
        AudioEvents.MusicChange += MusicChange;
        AudioEvents.AmbienceChange += AmbienceChange;
        AudioEvents.SfxTrigger += SfxTrigger;
    }

    private void OnDisable()
    {
        AudioEvents.MusicChange -= MusicChange;
        AudioEvents.AmbienceChange -= AmbienceChange;
        AudioEvents.SfxTrigger -= SfxTrigger;
    }

    private void Start()
    {
        AudioSourcesSetup();
    }

    private void MusicChange(string pa_MusicTrackName)
    {
        pr_MusicSource.clip = so_Music.FetchMusicTrack(pa_MusicTrackName);
    }

    private void AmbienceChange(string pa_AmbienceTrackName)
    {
        pr_AmbienceSource.clip = so_Ambience.FetchAmbienceTrack(pa_AmbienceTrackName);
    }

    private void SfxTrigger(string pa_SfxClipName)
    {
        foreach (AudioSource l_AudioSource in pr_SfxSources)
        {
            if (!l_AudioSource.isPlaying) l_AudioSource.clip = so_Sfx.FetchSfxClip(pa_SfxClipName);
        }
    }

    private void AudioSourcesSetup()
    {
        pr_MusicSource.loop = true;
        pr_MusicSource.volume = 0.6f;

        pr_AmbienceSource.loop = true;
        pr_AmbienceSource.volume = 0.4f;

        foreach (AudioSource l_AudioSource in pr_SfxSources)
        {
            l_AudioSource.loop = false;
            l_AudioSource.volume = 0.75f;
        }
    }
}
