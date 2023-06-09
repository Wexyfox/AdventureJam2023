using UnityEngine;

public class CheckIfGertDead : MonoBehaviour
{
    [SerializeField] private NewWarpLocation s_NewWarpLocation;
    [SerializeField] private GertDead so_GertDead;

    private void Start()
    {
        if (so_GertDead.GetDeadValue())
        {
            Debug.Log("Switched to gert dead scene");
        }
        if (so_GertDead.GetDeadValue()) s_NewWarpLocation.UpdateWarpLocation();
    }
}
