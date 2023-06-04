using UnityEngine;

public class IdleSpellFinishReset : StateMachineBehaviour
{
    [SerializeField] private string pr_SpellName;

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(pr_SpellName, false);
        animator.SetBool("Idle", true);
        SpellCastingMode l_SpellCastingMode = GameObject.FindAnyObjectByType<SpellCastingMode>();
        l_SpellCastingMode.SpellcastingModeDisable();
    }
}
