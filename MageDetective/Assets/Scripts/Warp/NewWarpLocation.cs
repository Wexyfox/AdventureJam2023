using UnityEngine;

public class NewWarpLocation : MonoBehaviour
{
    [SerializeField] private string pr_NewScene;
    [SerializeField] private WarpTrigger s_WarpTrigger;

    public void UpdateWarpLocation()
    {
        s_WarpTrigger.SceneNameUpdate(pr_NewScene);
    }
}
