using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private SpawnTransforms s_SpawnTransforms;
    [SerializeField] private ScenePositionSO so_ScenePosition;
    [SerializeField] private string e_MusicTrack;
    [SerializeField] private string e_AmbienceTrack;
    
    private void Start()
    {
        int l_TempInt = so_ScenePosition.PositionIndex();
        Transform l_TempTransform = s_SpawnTransforms.SceneStartingPosition(l_TempInt);
        GameObject.FindGameObjectWithTag("Player").transform.position = l_TempTransform.position;

        if (e_MusicTrack != "") AudioEvents.InvokeMusicChange(e_MusicTrack);
        if (e_AmbienceTrack != "") AudioEvents.InvokeAmbienceChange(e_AmbienceTrack);
        FadeEvents.InvokeFadeIn();
    }
}
