using UnityEngine;
using UnityEngine.InputSystem;

public class InputInvoker : MonoBehaviour
{
    #region Editor Fields

    private PlayerInput pr_PlayerInput; //Action Maps
    [SerializeField] private SpellCastingMode s_SpellCastingMode;
    [SerializeField] private NotebookMode s_NotebookMode;

    #endregion

    #region Private Fields

    private int pr_XAxis;
    private int pr_YAxis;

    #endregion

    private void Awake()
    {
        pr_PlayerInput = new PlayerInput();

        pr_XAxis = 0;
        pr_YAxis = 0;
    }

    #region Event Subscriptions

    private void OnEnable()
    {
        pr_PlayerInput.Movement.Up.performed += UpPressed;
        pr_PlayerInput.Movement.Down.performed += DownPressed;
        pr_PlayerInput.Movement.Left.performed += LeftPressed;
        pr_PlayerInput.Movement.Right.performed += RightPressed;
        pr_PlayerInput.Movement.Up.canceled += UpReleased;
        pr_PlayerInput.Movement.Down.canceled += DownReleased;
        pr_PlayerInput.Movement.Left.canceled += LeftReleased;
        pr_PlayerInput.Movement.Right.canceled += RightReleased;
        pr_PlayerInput.Movement.Enable();

        pr_PlayerInput.Triggers.NotebookMode.started += NotebookModeToggle;
        pr_PlayerInput.Triggers.NotebookMode.Enable();

        pr_PlayerInput.Triggers.SpellMode.started += SpellModeToggle;
        pr_PlayerInput.Triggers.SpellMode.Enable();

        pr_PlayerInput.Triggers.Interaction.started += InteractionAttempt;
        pr_PlayerInput.Triggers.Interaction.Enable();

        pr_PlayerInput.Spells.SpellUp.performed += SpellUp;
        pr_PlayerInput.Spells.SpellDown.performed += SpellDown;
        pr_PlayerInput.Spells.SpellLeft.performed += SpellLeft;
        pr_PlayerInput.Spells.SpellRight.performed += SpellRight;
        pr_PlayerInput.Spells.Enable();
    }

    private void OnDisable()
    {
        pr_PlayerInput.Movement.Up.performed -= UpPressed;
        pr_PlayerInput.Movement.Down.performed -= DownPressed;
        pr_PlayerInput.Movement.Left.performed -= LeftPressed;
        pr_PlayerInput.Movement.Right.performed -= RightPressed;
        pr_PlayerInput.Movement.Up.canceled -= UpReleased;
        pr_PlayerInput.Movement.Down.canceled -= DownReleased;
        pr_PlayerInput.Movement.Left.canceled -= LeftReleased;
        pr_PlayerInput.Movement.Right.canceled -= RightReleased;
        pr_PlayerInput.Movement.Disable();

        pr_PlayerInput.Triggers.NotebookMode.started -= NotebookModeToggle;
        pr_PlayerInput.Triggers.NotebookMode.Disable();

        pr_PlayerInput.Triggers.SpellMode.started -= SpellModeToggle;
        pr_PlayerInput.Triggers.SpellMode.Disable();

        pr_PlayerInput.Triggers.Interaction.started -= InteractionAttempt;
        pr_PlayerInput.Triggers.Interaction.Disable();

        pr_PlayerInput.Spells.SpellUp.performed -= SpellUp;
        pr_PlayerInput.Spells.SpellDown.performed -= SpellDown;
        pr_PlayerInput.Spells.SpellLeft.performed -= SpellLeft;
        pr_PlayerInput.Spells.SpellRight.performed -= SpellRight;
        pr_PlayerInput.Spells.Disable();
    }

    #endregion

    #region Movement Actions

    private void UpPressed(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        pr_YAxis += 1;
        MovementDirection();
    }

    private void DownPressed(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        pr_YAxis -= 1;
        MovementDirection();
    }

    private void LeftPressed(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;

        if (s_NotebookMode.Mode())
        {
            NotebookReadingEvents.InvokeNotebookPageTurnLeft();
            return;
        }

        pr_XAxis -= 1;
        MovementDirection();
    }

    private void RightPressed(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;

        if (s_NotebookMode.Mode())
        {
            NotebookReadingEvents.InvokeNotebookPageTurnRight();
            return;
        }

        pr_XAxis += 1;
        MovementDirection();
    }

    private void UpReleased(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        pr_YAxis -= 1;
        MovementDirection();
    }

    private void DownReleased(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        pr_YAxis += 1;
        MovementDirection();
    }

    private void LeftReleased(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        pr_XAxis += 1;
        MovementDirection();
    }

    private void RightReleased(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        pr_XAxis -= 1;
        MovementDirection();
    }

    private void MovementDirection()
    {
        //Debug.Log("X: " + pr_XAxis.ToString() + "    Y: " + pr_YAxis.ToString());

        if (pr_YAxis == 0 && pr_XAxis == 0)
        {
            InputEvents.InvokeMoveStop();
        }

        if (pr_YAxis == 1)
        {
            if (pr_XAxis == 1)
            {
                InputEvents.InvokeMoveUpRight();
            }
            else if (pr_XAxis == -1)
            {
                InputEvents.InvokeMoveUpLeft();
            }
            else
            {
                InputEvents.InvokeMoveUp();
            }
        }
        else if (pr_YAxis == -1)
        {
            if (pr_XAxis == 1)
            {
                InputEvents.InvokeMoveDownRight();
            }
            else if (pr_XAxis == -1)
            {
                InputEvents.InvokeMoveDownLeft();
            }
            else
            {
                InputEvents.InvokeMoveDown();
            }
        }
        else
        {
            if (pr_XAxis == 1)
            {
                InputEvents.InvokeMoveRight();
            }
            else if (pr_XAxis == -1)
            {
                InputEvents.InvokeMoveLeft();
            }
        }
    }

    #endregion

    #region Notebook Actions

    private void NotebookModeToggle(InputAction.CallbackContext pa_Callback)
    {
        InputEvents.InvokeNotebookModeToggle();
    }

    #endregion

    #region Spell Actions

    private void SpellModeToggle(InputAction.CallbackContext pa_Callback)
    {
        InputEvents.InvokeSpellcastingModeToggle();
    }

    private void SpellUp(InputAction.CallbackContext pa_Callback)
    {
        InputEvents.InvokeSpellUp();
    }

    private void SpellDown(InputAction.CallbackContext pa_Callback)
    {
        InputEvents.InvokeSpellDown();
    }

    private void SpellLeft(InputAction.CallbackContext pa_Callback)
    {
        InputEvents.InvokeSpellLeft();
    }

    private void SpellRight(InputAction.CallbackContext pa_Callback)
    {
        InputEvents.InvokeSpellRight();
    }

    #endregion

    private void InteractionAttempt(InputAction.CallbackContext pa_Callback)
    {
        if (s_SpellCastingMode.Mode()) return;
        if (s_NotebookMode.Mode()) return;
        InteractionEvents.InvokeInteractionAttempt();
    }

    #region Public Functions

    public bool IdleCheck()
    {
        return (pr_YAxis == 0 && pr_XAxis == 0);
    }

    #endregion
}
