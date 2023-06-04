using UnityEngine;

public class NotebookMode : MonoBehaviour
{
    [SerializeField] private InputInvoker s_InputInvoker;
    [SerializeField] private SpellCastingMode s_SpellCastingMode;
    [SerializeField] private bool pr_NotebookModeActivated = false;

    private void OnEnable()
    {
        InputEvents.NotebookModeToggle += NotebookModeToggle;
    }

    private void OnDisable()
    {
        InputEvents.NotebookModeToggle -= NotebookModeToggle;
    }

    private void NotebookModeToggle()
    {
        if (!pr_NotebookModeActivated && !s_SpellCastingMode.Mode() && s_InputInvoker.IdleCheck())
        {
            pr_NotebookModeActivated = true;
            NotebookReadingEvents.InvokeNotebookReadingModeActivate();
            return;
        }
        else
        {
            pr_NotebookModeActivated = false;
            NotebookReadingEvents.InvokeNotebookReadingModeDeactivate();
        }
    }

    public bool Mode()
    {
        return pr_NotebookModeActivated;
    }
}
