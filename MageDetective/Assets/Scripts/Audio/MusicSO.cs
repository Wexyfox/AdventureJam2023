using UnityEngine;

[CreateAssetMenu(fileName = "MusicAssets", menuName = "ScriptableObjects/MusicAssets")]
public class MusicSO : ScriptableObject
{
    [System.Serializable]
    public class MusicTrack
    {
        public string pu_MusicTrackName;
        public AudioClip pu_MusicTrackFile;
    }

    [SerializeField] private MusicTrack[] MusicTracks;
    [SerializeField] private AudioClip pr_DefaultMusic;

    public AudioClip FetchMusicTrack(string pa_MusicTrackName)
    {
        foreach (MusicTrack l_MusicTrack in MusicTracks)
        {
            if (l_MusicTrack.pu_MusicTrackName == pa_MusicTrackName) return l_MusicTrack.pu_MusicTrackFile;
        }
        return pr_DefaultMusic;
    }
}
