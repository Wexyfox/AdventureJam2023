using UnityEngine;

public class SpellCastingMode : MonoBehaviour
{
    [SerializeField] private InputInvoker s_InputInvoker;
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
        if (!pr_SpellModeActivated && s_InputInvoker.IdleCheck())
        {
            pr_SpellModeActivated = true;
            SpellCastingEvents.InvokeSpellCastingModeActivate();
        }
        else
        {
            pr_SpellModeActivated = false;
            SpellCastingEvents.InvokeSpellCastingModeDeactivate();
        }
    }

    public void SpellcastingModeDisable()
    {
        pr_SpellModeActivated = false;
        SpellCastingEvents.InvokeSpellCastingModeDeactivate();
    }

    public bool Mode()
    {
        return pr_SpellModeActivated;
    }
}
