using System.Threading.Tasks;
using UnityEngine;

public class SpellCastingCombination : MonoBehaviour
{
    [SerializeField] private SpellCastingMode s_SpellCastingMode;

    [SerializeField] private bool pr_StartedCasting;
    [SerializeField] private string pr_SpellComponents;

    private int pr_DisableDelayMiliseconds = 3000;

    private void OnEnable()
    {
        InputEvents.SpellUp += SpellUp;
        InputEvents.SpellDown += SpellDown;
        InputEvents.SpellLeft += SpellLeft;
        InputEvents.SpellRight += SpellRight;
    }
    private void OnDisable()
    {
        InputEvents.SpellUp -= SpellUp;
        InputEvents.SpellDown -= SpellDown;
        InputEvents.SpellLeft -= SpellLeft;
        InputEvents.SpellRight -= SpellRight;
    }

    private void SpellUp()
    {
        if (!s_SpellCastingMode.Mode())
        {
            return;
        }

        if (!pr_StartedCasting)
        {
            pr_StartedCasting = true;
            DelayDisable();
        }

        pr_SpellComponents += "u";
        SpellChecks();
    }

    private void SpellDown()
    {
        if (!s_SpellCastingMode.Mode())
        {
            return;
        }

        if (!pr_StartedCasting)
        {
            pr_StartedCasting = true;
            DelayDisable();
        }

        pr_SpellComponents += "d";
        SpellChecks();
    }

    private void SpellLeft()
    {
        if (!s_SpellCastingMode.Mode())
        {
            return;
        }

        if (!pr_StartedCasting)
        {
            pr_StartedCasting = true;
            DelayDisable();
        }

        pr_SpellComponents += "l";
        SpellChecks();
    }

    private void SpellRight()
    {
        if (!s_SpellCastingMode.Mode())
        {
            return;
        }

        if (!pr_StartedCasting)
        {
            pr_StartedCasting = true;
            DelayDisable();
        }

        pr_SpellComponents += "r";
        SpellChecks();
    }

    private void SpellChecks()
    {
        switch (pr_SpellComponents)
        {
            case "dr":
                Debug.Log("Light spell casted");
                Disable();
                break;
        }
    }

    private async void DelayDisable()
    {
        await Task.Delay(pr_DisableDelayMiliseconds);
        if (pr_StartedCasting)
        {
            Debug.Log("Casting failed");
            Disable();
        }
    }

    private void Disable()
    {
        pr_StartedCasting = false;
        pr_SpellComponents = "";
        s_SpellCastingMode.SpellcastingModeDisable();
    }
}
