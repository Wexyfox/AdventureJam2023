using UnityEngine.Events;

public static class SpellCastingEvents
{
    public static event UnityAction SpellCastingModeActivate;

    public static void InvokeSpellCastingModeActivate()
    {
        SpellCastingModeActivate?.Invoke();
    }

    public static event UnityAction SpellCastingModeDeactivate;

    public static void InvokeSpellCastingModeDeactivate()
    {
        SpellCastingModeDeactivate?.Invoke();
    }

    public static event UnityAction LightSpell;

    public static void InvokeLightSpell()
    {
        LightSpell?.Invoke();
    }

    public static event UnityAction UVLightSpell;

    public static void InvokeUVLightSpell()
    {
        UVLightSpell?.Invoke();
    }

    public static event UnityAction RevealSpell;

    public static void InvokeRevealSpell()
    {
        RevealSpell?.Invoke();
    }

    public static event UnityAction SpellFizzle;

    public static void InvokeSpellFizzle()
    {
        SpellFizzle?.Invoke();
    }
}
