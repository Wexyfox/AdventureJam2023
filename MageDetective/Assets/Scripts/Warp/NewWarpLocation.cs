using UnityEngine;

public class NewWarpLocation : MonoBehaviour
{
    [SerializeField] private string pr_NewScene;
    [SerializeField] private int pr_NewStartingPositionIndex;
    [SerializeField] private WarpTrigger s_WarpTrigger;

    public void UpdateWarpLocation()
    {
        s_WarpTrigger.SceneNameUpdate(pr_NewScene, pr_NewStartingPositionIndex);
    }
}
