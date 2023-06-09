using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpTrigger : MonoBehaviour
{
    [SerializeField] private string e_NextSceneName;
    [SerializeField] private int e_SpawnTransformIndex;
    [SerializeField] private ScenePositionSO so_ScenePosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        so_ScenePosition.SetPositionIndex(e_SpawnTransformIndex);
        StartCoroutine(Transition());
    }

    private IEnumerator Transition()
    {
        if (e_NextSceneName == "") yield return null;

        InputEvents.InvokeDisableInputs();
        FadeEvents.InvokeFadeOut();
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync(e_NextSceneName, LoadSceneMode.Single);
    }

    public void SceneNameUpdate(string pa_NewSceneName, int pa_NewStartingPositionIndex)
    {
        e_NextSceneName = pa_NewSceneName;
        e_SpawnTransformIndex = pa_NewStartingPositionIndex;
    }
}
