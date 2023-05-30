using UnityEngine;
using PixelCrushers.DialogueSystem;

public class TalkingTrigger : MonoBehaviour
{
    private DialogueSystemTrigger[] pr_DialogueSystemTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pr_DialogueSystemTrigger = collision.gameObject.GetComponents<DialogueSystemTrigger>();
    }
}
