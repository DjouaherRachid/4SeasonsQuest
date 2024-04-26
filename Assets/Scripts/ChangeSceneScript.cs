using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    public void ChangeSceneNow(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}