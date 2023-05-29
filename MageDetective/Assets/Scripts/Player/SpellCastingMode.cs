using UnityEngine;

public class SpellCastingMode : MonoBehaviour
{
    [SerializeField] private bool pr_SpellModeActivated;

    private void OnEnable()
    {
        InputEvents.SpellcastingModeToggle += SpellcastingModeToggle;
    }

    private void OnDisable()
    {
        InputEvents.SpellcastingModeToggle -= SpellcastingModeToggle;
    }

    private void SpellcastingModeToggle()
    {
        pr_SpellModeActivated = !pr_SpellModeActivated;
    }

    public void SpellcastingModeDisable()
    {
        pr_SpellModeActivated = false;
    }

    public bool Mode()
    {
        return pr_SpellModeActivated;
    }
}
