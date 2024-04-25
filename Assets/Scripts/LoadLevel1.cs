using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public void ChangeSceneNow(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}