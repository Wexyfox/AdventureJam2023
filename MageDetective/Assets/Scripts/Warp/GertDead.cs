using UnityEngine;

[CreateAssetMenu(fileName = "GertDead", menuName = "ScriptableObjects/GertDead")]
public class GertDead : ScriptableObject
{
    [SerializeField] private bool pu_GertDead = false;
    
    public void SetGertDead()
    {
        pu_GertDead = true;
    }

    public bool GetDeadValue()
    {
        return pu_GertDead;
    }
}
