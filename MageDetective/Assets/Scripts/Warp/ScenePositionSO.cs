using UnityEngine;

[CreateAssetMenu(fileName = "TransitionPositionIndexes", menuName = "ScriptableObjects/TranisitionPosition")]
public class ScenePositionSO : ScriptableObject
{
    [SerializeField] private int pr_SceneTransitionPosition = 0;

    public void SetPositionIndex(int pa_NewPositionIndex)
    {
        pr_SceneTransitionPosition = pa_NewPositionIndex;
    }

    public int PositionIndex()
    {
        return pr_SceneTransitionPosition;
    }
}
