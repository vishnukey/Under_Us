using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderComponent : MonoBehaviour
{
    [SerializeField] private string sceneToLoadName;
    [SerializeField] private bool additive;

    private void OnEnable()
    {
        LoadSceneMode loadSceneMode = additive ? LoadSceneMode.Additive : LoadSceneMode.Single;
        SceneManager.LoadScene(sceneToLoadName, loadSceneMode);
    }
}
