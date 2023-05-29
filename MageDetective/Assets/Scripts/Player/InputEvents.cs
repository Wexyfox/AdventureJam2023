using UnityEngine.Events;

public static class InputEvents
{
    #region Move Events

    public static event UnityAction MoveUp;

    public static void InvokeMoveUp()
    {
        MoveUp?.Invoke();
    }

    public static event UnityAction MoveDown;

    public static void InvokeMoveDown()
    {
        MoveDown?.Invoke();
    }

    public static event UnityAction MoveLeft;

    public static void InvokeMoveLeft()
    {
        MoveLeft?.Invoke();
    }

    public static event UnityAction MoveRight;

    public static void InvokeMoveRight()
    {
        MoveRight?.Invoke();
    }

    public static event UnityAction MoveUpLeft;

    public static void InvokeMoveUpLeft()
    {
        MoveUpLeft?.Invoke();
    }

    public static event UnityAction MoveUpRight;

    public static void InvokeMoveUpRight()
    {
        MoveUpRight?.Invoke();
    }

    public static event UnityAction MoveDownLeft;

    public static void InvokeMoveDownLeft()
    {
        MoveDownLeft?.Invoke();
    }

    public static event UnityAction MoveDownRight;

    public static void InvokeMoveDownRight()
    {
        MoveDownRight?.Invoke();
    }

    public static event UnityAction MoveStop;

    public static void InvokeMoveStop()
    {
        MoveStop?.Invoke();
    }

    #endregion

    #region Spell Events

    public static event UnityAction SpellcastingModeToggle;

    public static void InvokeSpellcastingModeToggle()
    {
        SpellcastingModeToggle?.Invoke();
    }

    public static event UnityAction SpellUp;

    public static void InvokeSpellUp()
    {
        SpellUp?.Invoke();
    }

    public static event UnityAction SpellDown;

    public static void InvokeSpellDown()
    {
        SpellDown?.Invoke();
    }

    public static event UnityAction SpellLeft;

    public static void InvokeSpellLeft()
    {
        SpellLeft?.Invoke();
    }

    public static event UnityAction SpellRight;

    public static void InvokeSpellRight()
    {
        SpellRight?.Invoke();
    }

    #endregion
}
