using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpTrigger : MonoBehaviour
{
    [SerializeField] private string pr_NextSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        StartCoroutine(Transition());
    }

    private IEnumerator Transition()
    {
        if (pr_NextSceneName == "") yield return null;

        InputEvents.InvokeDisableInputs();
        FadeEvents.InvokeFadeOut();
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync(pr_NextSceneName, LoadSceneMode.Single);
    }

    public void SceneNameUpdate(string pa_NewSceneName)
    {
        pr_NextSceneName = pa_NewSceneName;
    }
}
