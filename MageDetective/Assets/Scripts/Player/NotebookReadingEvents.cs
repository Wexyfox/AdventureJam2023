using UnityEngine.Events;
public class NotebookReadingEvents
{
    public static event UnityAction NotebookReadingModeActivate;

    public static void InvokeNotebookReadingModeActivate()
    {
        NotebookReadingModeActivate?.Invoke();
    }

    public static event UnityAction NotebookReadingModeDeactivate;

    public static void InvokeNotebookReadingModeDeactivate()
    {
        NotebookReadingModeDeactivate?.Invoke();
    }

    public static event UnityAction NotebookPageTurnLeft;

    public static void InvokeNotebookPageTurnLeft()
    {
        NotebookPageTurnLeft?.Invoke();
    }

    public static event UnityAction NotebookPageTurnRight;

    public static void InvokeNotebookPageTurnRight()
    {
        NotebookPageTurnRight?.Invoke();
    }
}
