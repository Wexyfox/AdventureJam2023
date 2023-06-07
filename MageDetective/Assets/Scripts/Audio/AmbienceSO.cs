using UnityEngine;

[CreateAssetMenu(fileName = "AmbienceAssets", menuName = "ScriptableObjects/AmbienceAssets")]
public class AmbienceSO : ScriptableObject
{
    [System.Serializable]
    public class AmbienceTrack
    {
        public string pu_AmbienceTrackName;
        public AudioClip pu_AmbienceTrackFile;
    }

    [SerializeField] private AmbienceTrack[] AmbienceTracks;
    [SerializeField] private AudioClip pr_DefaultAmbience;

    public AudioClip FetchAmbienceTrack(string pa_AmbienceTrackName)
    {
        foreach (AmbienceTrack l_AmbienceTrack in AmbienceTracks)
        {
            if (l_AmbienceTrack.pu_AmbienceTrackName == pa_AmbienceTrackName) return l_AmbienceTrack.pu_AmbienceTrackFile;
        }
        return pr_DefaultAmbience;
    }
}