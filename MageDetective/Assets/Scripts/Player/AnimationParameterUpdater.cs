using System.Collections.Generic;
using UnityEngine;

public class AnimationParameterUpdater : MonoBehaviour
{
    #region Editor Fields

    [SerializeField] private Animator u_PlayerAnimator;
    [SerializeField] private SpellCastingMode s_SpellCastingMode;

    #endregion

    #region Private Fields

    private List<string> u_ParamterList;

    #endregion

    #region Event Subscriptions

    private void OnEnable()
    {
        InputEvents.MoveUp += MoveUp;
        InputEvents.MoveDown += MoveDown;
        InputEvents.MoveLeft += MoveLeft;
        InputEvents.MoveRight += MoveRight;

        InputEvents.MoveUpLeft += MoveUpLeft;
        InputEvents.MoveUpRight += MoveUpRight;
        InputEvents.MoveDownLeft += MoveDownLeft;
        InputEvents.MoveDownRight += MoveDownRight;

        InputEvents.MoveStop += MoveStop;

        SpellCastingEvents.SpellCastingModeActivate += SpellCastingModeActivate;
        SpellCastingEvents.SpellCastingModeDeactivate += SpellCastingModeDeactivate;

        SpellCastingEvents.LightSpell += LightSpell;
        SpellCastingEvents.UVLightSpell += UVLightSpell;
        SpellCastingEvents.RevealSpell += RevealSpell;
        SpellCastingEvents.SpellFizzle += SpellFizzle;
    }

    private void OnDisable()
    {
        InputEvents.MoveUp -= MoveUp;
        InputEvents.MoveDown -= MoveDown;
        InputEvents.MoveLeft -= MoveLeft;
        InputEvents.MoveRight -= MoveRight;

        InputEvents.MoveUpLeft -= MoveUpLeft;
        InputEvents.MoveUpRight -= MoveUpRight;
        InputEvents.MoveDownLeft -= MoveDownLeft;
        InputEvents.MoveDownRight -= MoveDownRight;

        InputEvents.MoveStop -= MoveStop;

        SpellCastingEvents.SpellCastingModeActivate -= SpellCastingModeActivate;
        SpellCastingEvents.SpellCastingModeDeactivate -= SpellCastingModeDeactivate;

        SpellCastingEvents.LightSpell -= LightSpell;
        SpellCastingEvents.UVLightSpell -= UVLightSpell;
        SpellCastingEvents.RevealSpell -= RevealSpell;
        SpellCastingEvents.SpellFizzle -= SpellFizzle;
    }

    #endregion

    #region Movement Event Reactions

    private void MoveUp()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingUp", true);
    }

    private void MoveDown()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingDown", true);
    }

    private void MoveLeft()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingLeft", true);
    }

    private void MoveRight()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingRight", true);
    }

    private void MoveUpLeft()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingUpLeft", true);
    }

    private void MoveUpRight()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingUpRight", true);
    }

    private void MoveDownLeft()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingDownLeft", true);
    }

    private void MoveDownRight()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("WalkingDownRight", true);
    }

    private void MoveStop()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("Idle", true);
    }

    #endregion

    #region Spell Event Reactions

    private void SpellCastingModeActivate()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("CastingSpell", true);
    }

    private void SpellCastingModeDeactivate()
    {
        UncheckParameters();
        u_PlayerAnimator.SetBool("CastingSpell", true);
    }

    private void LightSpell()
    {
        u_PlayerAnimator.SetBool("LightCasted", true);
        UncheckParameters();
    }

    private void UVLightSpell()
    {
        u_PlayerAnimator.SetBool("UVLightCasted", true);
        UncheckParameters();
    }

    private void RevealSpell()
    {
        u_PlayerAnimator.SetBool("RevealCasted", true);
        UncheckParameters();
    }

    private void SpellFizzle()
    {
        u_PlayerAnimator.SetBool("SpellFizzle", true);
        UncheckParameters();
    }

    #endregion

    private void Awake()
    {
        u_ParamterList = new List<string>
        { 
            "CastingSpell",
            "LightCasted",
            "UVLightCasted",
            "RevealCasted",
            "SpellFizzle",
            "WalkingUp",
            "WalkingDown",
            "WalkingLeft",
            "WalkingRight",
            "WalkingUpLeft",
            "WalkingUpRight",
            "WalkingDownLeft",
            "WalkingDownRight",
            "Idle"
        };
    }

    private void UncheckParameters()
    {
        foreach (string l_ParameterName in u_ParamterList)
        {
            u_PlayerAnimator.SetBool(l_ParameterName, false);
        }
    }
}
