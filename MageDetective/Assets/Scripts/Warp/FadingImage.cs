using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FadingImage : MonoBehaviour
{
    [SerializeField] private Image u_Image;

    private float pr_MillisecondDelay = 25;

    private void OnEnable()
    {
        FadeEvents.FadeIn += FadeIn;
        FadeEvents.FadeOut += FadeOut;
    }

    private void OnDisable()
    {
        FadeEvents.FadeIn -= FadeIn;
        FadeEvents.FadeOut -= FadeOut;
    }

    private async void FadeIn()
    {
        float l_TempMilliSeconds = 2000;
        while (l_TempMilliSeconds > 0)
        {
            Color l_TempColor = u_Image.color;
            l_TempColor.a = (l_TempMilliSeconds / 2000);
            u_Image.color = l_TempColor;

            l_TempMilliSeconds -= pr_MillisecondDelay;
            await Task.Delay((int)pr_MillisecondDelay);
        }
    }

    private async void FadeOut()
    {
        float l_TempMilliSeconds = 0;
        while (l_TempMilliSeconds < 2000)
        {
            Color l_TempColor = u_Image.color;
            l_TempColor.a = (l_TempMilliSeconds / 2000);
            u_Image.color = l_TempColor;

            l_TempMilliSeconds += pr_MillisecondDelay;
            await Task.Delay((int)pr_MillisecondDelay);
        }
    }
}
