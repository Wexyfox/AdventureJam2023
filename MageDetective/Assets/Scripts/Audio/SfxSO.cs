using UnityEngine;

[CreateAssetMenu(fileName = "SfxAssets", menuName = "ScriptableObjects/SfxAssets")]
public class SfxSO : ScriptableObject
{
    [System.Serializable]
    public class SfxClip
    {
        public string pu_SfxClipName;
        public AudioClip pu_SfxClipFile;
    }

    [SerializeField] private SfxClip[] SfxClips;
    [SerializeField] private AudioClip pr_DefaultSfxClip;

    public AudioClip FetchSfxClip(string pa_SfxClipName)
    {
        foreach (SfxClip l_SfxClip in SfxClips)
        {
            if (l_SfxClip.pu_SfxClipName == pa_SfxClipName) return l_SfxClip.pu_SfxClipFile;
        }
        return pr_DefaultSfxClip;
    }
}
