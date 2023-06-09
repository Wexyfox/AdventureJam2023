using UnityEngine;

public class SpawnTransforms : MonoBehaviour
{
    [SerializeField] private Transform[] pr_SpawnTransforms;

    public Transform SceneStartingPosition(int pa_Index)
    {
        if (pa_Index > -1 && pa_Index < pr_SpawnTransforms.Length) return pr_SpawnTransforms[pa_Index];
        else return pr_SpawnTransforms[0];
    }
}
